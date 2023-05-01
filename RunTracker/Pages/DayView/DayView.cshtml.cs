using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using RunTracker.Models;

namespace RunTracker.Pages.DayView
{
    public class DayViewModel : PageModel
    {
        static public int index = 0;
        public List<Models.Run> RunList = new List<Models.Run>();
        public string displayDate;
        public void OnGet(string rundate, int runIndex)
        {
            index = runIndex;

            displayDate = rundate;
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {                           
                string sql = "SELECT * FROM Run WHERE UserID = @userID AND RunDate = @runDate";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", "1");
                cmd.Parameters.AddWithValue("@runDate", rundate);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {                        
                        Models.Run run = new Models.Run();
                        run.RunID = int.Parse(reader["RunID"].ToString());
                        run.RunName = reader["RunName"].ToString();
                        run.RunDate = reader["RunDate"].ToString();
                        run.StartTime = reader["StartTime"].ToString();
                        run.EndTime = reader["EndTime"].ToString();
                        run.Distance = decimal.Parse(reader["Distance"].ToString());
                        run.Duration = reader["Duration"].ToString();
                        run.Pace = reader["Pace"].ToString();
                        run.PhotoURL = reader["PhotoURL"].ToString();
                        run.LocationName = reader["LocationName"].ToString();
                        run.City = reader["City"].ToString();
                        run.State = reader["State"].ToString();
                        run.Country = reader["Country"].ToString();
                        RunList.Add(run);
                    }
                }
            }

        }//OnGet()

        //public IActionResult OnPost(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
        //    {
        //        string sql = "DELETE FROM Run WHERE RunID = @runID";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@runID", id);
        //        conn.Open();
        //        cmd.ExecuteNonQuery();

        //        return RedirectToPage("/DayView/DayView");
        //    }
        //}

        public void OnPost(string runDate, int runId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sql = "DELETE FROM Run WHERE RunDate=@runDate AND RunID=@runId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@runDate", runDate);
                cmd.Parameters.AddWithValue("@runId", runId);
                conn.Open();
                cmd.ExecuteNonQuery();
                OnGet(runDate, 0);
            }
        }
    }

}
