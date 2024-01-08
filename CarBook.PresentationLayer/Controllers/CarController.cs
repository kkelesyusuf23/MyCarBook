using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;

        public CarController(ICarService carService, ICarDetailService carDetailService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetListAll();
            return View(values);
        }
		public IActionResult Index2()
		{
			var values = _carService.TGetAllCarWithBrands();//bu method brand carCategori ve carStatus tablolarını da dahil ediyor
			return View(values);
		}
        public IActionResult CarDetail(int id)
        {
            var value = _carDetailService.TGetCarDetailByCarId(id);
            ViewBag.desc = value.Description;
            ViewBag.i = id;
            return View();
        }
	}
}
