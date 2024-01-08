using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
