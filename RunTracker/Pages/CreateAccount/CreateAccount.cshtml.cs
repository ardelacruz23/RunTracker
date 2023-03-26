using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;

namespace RunTracker.Pages
{
    public class CreateAccountModel : PageModel
    {
        // [BindProperty] DO WE NEED THIS ???????
        public Models.User NewUser = new User();
        public void OnGet()
        {

        }
    
        public void OnPost() 
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
                string sql = "INSERT INTO User(Email, FirstName, LastName, Salt, PasswordHash) " +
                    "VALUES (@email, @firstName, @lastName, @salt, @passwordHash)";

                // 3. 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", NewUser.Email);
                cmd.Parameters.AddWithValue("@firstName", NewUser.FirstName);
                cmd.Parameters.AddWithValue("@lastName", NewUser.LastName);
                cmd.Parameters.AddWithValue("@salt", NewUser.Salt);
                cmd.Parameters.AddWithValue("@passwordHash", NewUser.PasswordHash);

                // 4. 
                conn.Open();

                // 5.
                cmd.ExecuteNonQuery();
                // USE ExecuteNonQuery() for INSERT/DELETE sql commands
                // USE ExecuteReader for getting data from database, SELECT command

                // 6. connection will close automatically once Using{} block is exited

            }// USING

        }
    }
}
