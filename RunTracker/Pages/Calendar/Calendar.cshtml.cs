using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using RunTracker.Models;

namespace RunTracker.Pages
{
    public class CalendarModel : PageModel
    {
        static public int nav;
        public int year;
        static public DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
        public int month;
        public void OnGet(int value)
        {
            month = dt.Month + nav;
            year = dt.Year;
        }
                
        public void OnPostPrevious()
        {
            nav = nav - 1;
            OnGet(nav);
        }

        public void OnPostNext()
        {
            nav = nav + 1;
            OnGet(nav);
        }
    }
}
