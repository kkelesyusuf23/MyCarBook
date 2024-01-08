using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class UIAboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
