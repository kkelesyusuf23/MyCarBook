using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class UIDefaultController : Controller
    {
        private readonly ICarService _carService;

        public UIDefaultController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int? brandId, int? carCategoryId, string gearType, int? year)
        {
            // The same logic as the GET action

            var carsQuery = _carService.TGetAllCarWithBrands().AsQueryable();

            if (brandId.HasValue)
            {
                carsQuery = carsQuery.Where(c => c.BrandID == brandId);
            }

            if (carCategoryId.HasValue)
            {
                carsQuery = carsQuery.Where(c => c.CarCategoryID == carCategoryId);
            }

            if (!string.IsNullOrEmpty(gearType))
            {
                carsQuery = carsQuery.Where(c => string.Equals(c.GearType, gearType, StringComparison.OrdinalIgnoreCase));
            }

            if (year.HasValue)
            {
                carsQuery = carsQuery.Where(c => c.Year == year);
            }

            var filteredCars = carsQuery.ToList();




            return View("FilteredCarsList", filteredCars);
        }

        public IActionResult FilteredCarsList(List<Car> filteredCars)
        {
            return View(filteredCars);
        }
    }
}
