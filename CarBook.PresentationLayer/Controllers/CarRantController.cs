using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarRantController : Controller
    {
        private readonly ICarRantService _carRantService;
		private readonly UserManager<AppUser> _userManager;
		private readonly ICarService _carService;
		public CarRantController(ICarRantService carRantService, ICarService carService, UserManager<AppUser> userManager)
		{
			_carRantService = carRantService;
			_carService = carService;
			_userManager = userManager;
		}

		public IActionResult Index()
        {
            var values = _carRantService.TGetListAll();
            return View(values);
        }
		public IActionResult DeleteCarRant(int id)
		{
			var values = _carRantService.TGetById(id);
			_carRantService.TDelete(values);
			return RedirectToAction("Index");
		}
		
		[HttpGet]
		public ActionResult UpdateCarRant(int id)
		{
			List<SelectListItem> values = (from x in _carService.TGetAllCarWithBrands()
										   select new SelectListItem
										   {
											   Text = x.Brand.BrandName + " " + x.Model,
											   Value = x.CarID.ToString()
										   }).ToList();
			ViewBag.v = values;


			ViewBag.users = _userManager.Users.ToList();
			var value = _carRantService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public ActionResult UpdateCarRant(int id, string fullName, string Email, DateTime startDate, DateTime endDate)
		{
            var carRant = _carRantService.TGetById(id);


            int dayNumber = (int)(endDate - startDate).TotalDays;

            var car = _carService.TGetAllCarWithBrands().FirstOrDefault(x => x.CarID == carRant.CarID);

            int carDayPrice = (int)car.DailyPrice;

            // Update the properties of the existing CarRant
            carRant.FullName = fullName;
            carRant.Email = Email;
            carRant.DayNumber = dayNumber;
            carRant.TotalPrice = dayNumber * carDayPrice;

            // Save the changes
            _carRantService.TUpdate(carRant);

            return RedirectToAction("Index");
        }
	}
}
