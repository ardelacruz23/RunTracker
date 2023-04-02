using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;

namespace RunTracker.Pages.AddLocation
{
    public class AddLocationModel : PageModel
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
                 * INSERT INTO Run(LocationName, City, State, Country)
                 * VALUES (@locationName, @city, @state, @country)
                 * 3. Create a command to execute the query
                 * 4. Open the connection
                 * 5. Execute the command
                 * 6. Close the connection
                 *
                 */

                using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    // 2. Paramaterized Query
                    string sql = "INSERT INTO Run(LocationName, City, State, Country) " +
                        "VALUES (@locationName, @city,  @state, @country)";

                    // 3. 
                    SqlCommand cmd = new SqlCommand(sql, conn);
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
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }// onPost()

    }
}
