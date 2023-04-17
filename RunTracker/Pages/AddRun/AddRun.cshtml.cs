using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using RunTracker.Models;
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace RunTracker.Pages.Shared
{
    public class AddRunModel : PageModel
    {
        [BindProperty]
        public Models.Run NewRun { get; set; } = new Models.Run();
        [BindProperty]
        public string? Measurement { get; set; } 
        public List<String> Measurements = new List<String>();        
        public void OnGet()
        {
            Measurements.Add("Miles");
            Measurements.Add("Kilometers");
        }

        public IActionResult OnPost()
        {        
            if (ModelState.IsValid)
            {
                /*
                 * 1. Create a connection to the database using the connection string stored in appsettings.json
                 * 2. Write the SQL query to insert data
                 * INSERT INTO Run(RunName, StartTime, EndTime, Distance, PhotoURL)
                 * VALUES (@runName, @startTime, @endTime, @distance, @photoURL
                 * 3. Create a command to execute the query
                 * 4. Open the connection
                 * 5. Execute the command
                 * 6. Close the connection
                 *
                 */


                if (NewRun.PhotoURL == null)
                {
                    NewRun.PhotoURL = "N/A";
                }
                if (NewRun.LocationName == null) 
                {
                    NewRun.LocationName = "N/A";
                }
                if (NewRun.City == null)
                {
                    NewRun.City = "N/A";
                }
                if (NewRun.State == null) 
                {
                    NewRun.State = "N/A";
                }
                if (NewRun.Country == null) 
                {
                    NewRun.Country = "N/A";
                }                
                

                // Use the StartTime, EndTime and Distance to calculate the pace in mins per mile
                TimeOnly EndTime = TimeOnly.Parse(NewRun.EndTime);
                TimeOnly StartTime = TimeOnly.Parse(NewRun.StartTime);
                decimal calcPace;
                decimal calcTime = (decimal)(EndTime - StartTime).TotalMinutes;
                TimeSpan durationSpan = TimeSpan.FromMinutes((double)calcTime);
                TimeOnly durationTime = TimeOnly.FromTimeSpan(durationSpan);
                NewRun.Duration = durationTime.ToString();
                calcPace = (calcTime / NewRun.Distance);
                TimeSpan paceSpan= TimeSpan.FromMinutes((double)calcPace);                
                string paceString = paceSpan.ToString();


                using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    // 2. Paramaterized Query
                    string sql = "INSERT INTO [Run] (RunName, UserId, RunDate, StartTime, EndTime, Distance, Measurement, Duration, Pace, PhotoURL, LocationName, City, State, Country) " +
                        "VALUES (@runName, @userId, @runDate,  @startTime, @endTime, @distance, @measurement, @duration, @pace, @photoURL, @locationName, @city, @state, @country)";

                    // 3. 
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@runName", NewRun.RunName);
                    cmd.Parameters.AddWithValue("@userId", "1");
                    cmd.Parameters.AddWithValue("@runDate", NewRun.RunDate);
                    cmd.Parameters.AddWithValue("@startTime", NewRun.StartTime);
                    cmd.Parameters.AddWithValue("@endTime", NewRun.EndTime);
                    cmd.Parameters.AddWithValue("@distance", NewRun.Distance);
                    cmd.Parameters.AddWithValue("@measurement", "Measurement");
                    cmd.Parameters.AddWithValue("@duration", NewRun.Duration);
                    cmd.Parameters.AddWithValue("@pace", paceString);
                    cmd.Parameters.AddWithValue("@photoURL", NewRun.PhotoURL);
                    cmd.Parameters.AddWithValue("@locationName", NewRun.LocationName);
                    cmd.Parameters.AddWithValue("@city", NewRun.City);
                    cmd.Parameters.AddWithValue("@state", NewRun.State);
                    cmd.Parameters.AddWithValue("@country", NewRun.Country);

                    // 4. 
                    conn.Open();

                    // 5.
                    cmd.ExecuteNonQuery();
                    // USE ExecuteNonQuery() for INSERT/DELETE sql commands
                    // USE ExecuteReader for getting data from database, SELECT command

                    // 6. connection will close automatically once Using{} block is exited
                }// USING
                return RedirectToPage("/DayView/DayView");
            }
            else
            {
                return Page();
            }

        }// onPost()

    }//CLASS AddRunModel

}// namespace {} 

