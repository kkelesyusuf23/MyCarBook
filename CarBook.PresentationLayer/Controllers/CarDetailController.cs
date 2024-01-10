using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarDetailController : Controller
    {
        private readonly ICarDetailService _carDetailService;
		private readonly UserManager<AppUser> _userManager;
		private readonly ICarService _carService;

        public CarDetailController(ICarDetailService carDetailService, UserManager<AppUser> userManager, ICarService carService)
        {
            _carDetailService = carDetailService;
            _userManager = userManager;
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _carDetailService.TGetListAll();
            return View(values);
        }
		public IActionResult DeleteCarDetail(int id)
		{
			var values = _carDetailService.TGetById(id);
			_carDetailService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult AddCarDetail()
		{
            List<SelectListItem> values = (from x in _carService.TGetAllCarWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarID.ToString()
                                           }).ToList();
            ViewBag.v = values;


            ViewBag.users = _userManager.Users.ToList();
            return View();
		}
		[HttpPost]
		public ActionResult AddCarDetail(CarDetail carDetail)
		{
			_carDetailService.TInsert(carDetail);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult UpdateCarDetail(int id)
		{
            List<SelectListItem> values = (from x in _carService.TGetAllCarWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarID.ToString()
                                           }).ToList();
            ViewBag.v = values;


            ViewBag.users = _userManager.Users.ToList();
            var value = _carDetailService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public ActionResult UpdateCarDetail(CarDetail carDetail)
		{
			_carDetailService.TUpdate(carDetail);
			return RedirectToAction("Index");
		}

	}
}
