using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;

namespace RunTracker.Pages.EditRun
{
    public class EditRunModel : PageModel
    {
        [BindProperty]
        public Models.Run ExistingRun { get; set; } = new Models.Run();
        public void OnGet()
        {
            //using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            //{
            //    // 2. Paramaterized Query
            //    string sql = "SELECT * FROM [Run] (RunName, UserId, StartTime, EndTime, Distance, Pace, PhotoURL) " +
            //        "VALUES (@runName, @userId, @runDate,  @startTime, @endTime, @distance, @pace, @photoURL)";

            //    // 3. 
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("@runId", id);

            //    //cmd.Parameters.AddWithValue("@country", NewRun.Country);
            //    ExistingRun
            //    // 4. 
            //    conn.Open();

            //    // 5.
            //    cmd.ExecuteNonQuery();
            //    // USE ExecuteNonQuery() for INSERT/DELETE sql commands
            //    // USE ExecuteReader for getting data from database, SELECT command

            //    // 6. connection will close automatically once Using{} block is exited
            //}// USING
            //return RedirectToPage("Index");
        }

        /*
        public IActionResult OnPost()
        { 
            if (ModeState.IsValid)
            {
                using (SQLConnection conn = nwe SQLConnection(DBHelper.GetConnectionString()))
                {
                    string sql = "UPDATE Run SET RunName = @runName, "
                }
            }//IF
        }
        */
    }
}
