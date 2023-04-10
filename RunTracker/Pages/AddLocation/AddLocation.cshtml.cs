using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RunTracker.Models;
using RunTracker.Pages.Shared;

namespace RunTracker.Pages.AddLocation
{
    public class AddLocationModel : PageModel
    {        
        // NEED TO PULL THE DATA FROM AddRun Page NewRUn to update it with the Location INFO from the AddLocation Page!!
        public void OnGet(Models.Run NewRun)
        {

        }
        
        public IActionResult OnPost()
        {
            return RedirectToPage("/AddRun/AddRun");
        }//onPost()
    }
}
