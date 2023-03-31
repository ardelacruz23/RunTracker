using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;
using System;

namespace RunTracker.Pages.Shared
{
    public class AddRunModel : PageModel
    {
        [BindProperty]
        public Models.Run NewRun { get; set; } = new Models.Run();
        public void OnGet()
        {
        
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

                using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    // 2. Paramaterized Query
                    string sql = "INSERT INTO Run(RunName, StartTime, EndTime, Distance, PhotoURL) " +
                        "VALUES (@runName, @runDate,  @startTime, @endTime, @distance, @photoURL)";

                    // 3. 
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@runName", NewRun.RunName);
                    cmd.Parameters.AddWithValue("@runDate", NewRun.RunDate);
                    cmd.Parameters.AddWithValue("@startTime", NewRun.StartTime);
                    cmd.Parameters.AddWithValue("@endTime", NewRun.EndTime);
                    cmd.Parameters.AddWithValue("@distance", NewRun.Distance);
                    cmd.Parameters.AddWithValue("@photoURL", NewRun.PhotoURL);

                    // 4. 
                    conn.Open();

                    // 5.
                    cmd.ExecuteNonQuery();
                    // USE ExecuteNonQuery() for INSERT/DELETE sql commands
                    // USE ExecuteReader for getting data from database, SELECT command

                    // 6. connection will close automatically once Using{} block is exited
                }// USING
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }

    }//CLASS AddRunModel


}

