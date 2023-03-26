using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;

namespace RunTracker.Pages.DayView
{
    //[BindProperty]
    public class DayViewModel : PageModel
    {
        public List<Models.Run> RunList = new List<Models.Run>();
        public void OnGet()
        {
/*
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
/*
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {

                // 2. 
                // vvv This query will select all Runs from the database that match the specified Date
                // string sql = "SELECT RunName, StartTime, Distance, Pace, PhotoURL, LocationName, City, State, Country " +
                //              "FROM Run WHERE Date=**the current day the user selected on the calendar**" +
                //              "ORDER BY StartTime"

                // 3. 
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 4. 
                conn.Open();

                // 5.
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {   // while loop: Creates a new run object and reads in the specified fields from dbo.Run table
                    while (reader.Read()) 
                    {
                        Models.Run run = new Models.Run();
                        run.RunName = reader["RunName"].ToString();
                        run.Distance = decimal.Parse(reader["Distance"].ToString());
                        run.Pace = System.TimeOnly.Parse(reader["Pace"].ToString());
                        run.PhotoURL = reader["PhotoURL"].ToString();
                        run.LocationName = reader["LocationName"].ToString();
                        run.City = reader["City"].ToString();
                        run.State = reader["State"].ToString();
                        run.Country = reader["Country"].ToString();
                        RunList.Add(run);
                    }
                }
                // USE ExecuteNonQuery() for INSERT/DELETE sql commands
                // USE ExecuteReader for getting data from database, SELECT command

                // 6. database connection will close automatically with using{}
            }
*/
        }
    }
}
