using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carStatusService.TGetListAll();
            return View(values);
        }
		[HttpGet]
		public IActionResult AddCarStatus()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddCarStatus(CarStatus carStatus)
		{
			_carStatusService.TInsert(carStatus);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteCarStatus(int id)
		{
			var value = _carStatusService.TGetById(id);
			_carStatusService.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateCarStatus(int id)
		{
			var value = _carStatusService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateCarStatus(CarStatus carStatus)
		{
			_carStatusService.TUpdate(carStatus);
			return RedirectToAction("Index");
		}
	}
}
