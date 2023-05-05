using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace RunTracker.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public Credential LoginInfo { get; set; }

		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (ModelState.IsValid)
			{
				// Verify user credentials
				if (LoginInfo.Email == "admin@mysite.com" && LoginInfo.Password == "CSCI3321!")
				{
					// Create security context - Method 1
					// var claim1 = new Claim(ClaimTypes.Email, LoginInfo.Email);
					// var claim2 = new Claim(ClaimTypes.Name, "Angelica");
					// var claim3 = new Claim("Username", "Admin");
					// var calims = new List<Claim> { claim1, claim2 };

					// Create security context - Method 2
					var claims = new List<Claim>
					{
						new Claim(ClaimTypes.Email, LoginInfo.Email),
						new Claim(ClaimTypes.Name, "Angelica"),
						new Claim("Username", "Admin")
					};

					var identity = new ClaimsIdentity(claims, "RunTrackerCookie");
					ClaimsPrincipal principal = new ClaimsPrincipal(identity);

					await HttpContext.SignInAsync("RunTrackerCookie", principal);
					return RedirectToPage("/Calendar/Calendar");
				}
				return Page();
			}
			return Page();
		}
	}

	public class Credential
	{
		[Required(ErrorMessage ="Email is not valid")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is not valid")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}