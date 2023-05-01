using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace RunTracker.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		[BindProperty]
		public Credential LoginInfo { get; set; }

		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				// Verify user credentials
				if (LoginInfo.Email == "admin@mysite.com" && LoginInfo.Password == "CSCI3321!")
				{
					// Create security context
					// var claim1 = new Claim(ClaimTypes.Email, LoginInfo.Email);
					// var claim2 = new Claim(ClaimTypes.Name, "Angelica");
					// var claim3 = new Claim("Username", "Admin");
					// var calims = new List<Claim> { claim1, claim2 };

					var claims = new List<Claim>
					{
						new Claim(ClaimTypes.Email, LoginInfo.Email),
						new Claim(ClaimTypes.Name, "Angelica"),
						new Claim("Username", "Admin")
					};

					var identity = new ClaimsIdentity(claims, "RunTrackerCookie");
					ClaimsPrincipal principal = new ClaimsPrincipal(identity);

					await HttpContext.SignInAsync("RunTrackerCookie", principal);
					return RedirectToPage("/Index");
				}
				return Page();
			}
			return Page();
		}
	}

	public class Credential
	{
		[Required]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}