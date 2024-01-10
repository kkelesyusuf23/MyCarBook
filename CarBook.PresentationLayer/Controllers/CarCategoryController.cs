using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarCategoryController : Controller
    {
        private readonly ICarCategoryService _carCategoryService;

        public CarCategoryController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IActionResult Index()
        {
            var values = _carCategoryService.TGetListAll();
            return View(values);
        }
        public IActionResult DeleteCarCategory(int id)
        {
            var values = _carCategoryService.TGetById(id);
            _carCategoryService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddCarCategory()
        {
            return View();
        }
        [HttpPost]
		public ActionResult AddCarCategory(CarCategory carCategory)
		{
            _carCategoryService.TInsert(carCategory);
			return RedirectToAction("Index");
		}
        [HttpGet]
        public ActionResult UpdateCarCategory(int id)
        {
            var value = _carCategoryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCarCategory(CarCategory carCategory)
        {
            _carCategoryService.TUpdate(carCategory);
            return RedirectToAction("Index");
        }
    }
}
