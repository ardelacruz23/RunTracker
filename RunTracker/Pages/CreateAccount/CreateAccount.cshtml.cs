using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;

namespace RunTracker.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty] 
        public Models.User NewUser { get; set; } = new Models.User();
        public void OnGet()
        {

        }
    
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {                
                 // 1. Create a connection to the database using the connection string stored in appsettings.json                 
                using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    // 2. Write the SQL query
                    string sql = "INSERT INTO User (Email, FirstName, Salt, PasswordHash) " +
                        "VALUES (@email, @firstName, @salt, @passwordHash)";

                    // 3. Create a command to execute the query
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", NewUser.Email);
                    cmd.Parameters.AddWithValue("@firstName", NewUser.FirstName);
                    cmd.Parameters.AddWithValue("@salt", NewUser.Salt);
                    cmd.Parameters.AddWithValue("@passwordHash", NewUser.PasswordHash);

                    // 4. Open the connection
                    conn.Open();

                    // 5. Execute the command
                    cmd.ExecuteNonQuery();
                    // USE ExecuteNonQuery() for INSERT/DELETE sql commands
                    // USE ExecuteReader for getting data from database, SELECT command

                    // 6. connection will close automatically once Using{} block is exited
                }// USING
                return RedirectToPage("Index");
            }// IF
            else
            {
                return Page();
            }
        }
    }
}
