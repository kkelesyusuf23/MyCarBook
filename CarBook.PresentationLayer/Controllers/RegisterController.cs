using CarBook.EntityLayer.Concrete;
using CarBook.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
		{
			var appUser = new AppUser()
			{
				Name = registerViewModel.Name,
				Surname = registerViewModel.Surname,
				Email = registerViewModel.Email,
				UserName = registerViewModel.Username
			};
			var result = await _userManager.CreateAsync(appUser,registerViewModel.Password);
			if(result.Succeeded)
			{
				return RedirectToAction("Index","Login");
			}
			else
			{
				foreach(var item in result.Errors)
				{
                    ModelState.AddModelError("", item.Description);
                }
			}
			return View();
		}
	}
}
