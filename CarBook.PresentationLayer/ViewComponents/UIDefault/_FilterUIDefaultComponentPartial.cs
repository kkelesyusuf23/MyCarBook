using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _FilterUIDefaultComponentPartial : ViewComponent
    {
        private readonly ICarService _carService;
        private readonly IBrandService _brandService;
        private readonly ICarCategoryService _carCategoryService;

        public _FilterUIDefaultComponentPartial(ICarService carService, IBrandService brandService, ICarCategoryService carCategoryService)
        {
            _carService = carService;
            _brandService = brandService;
            _carCategoryService = carCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var Brands = _brandService.TGetListAll();
            ViewBag.BrandsList = new SelectList(Brands, "BrandID", "BrandName");

            var CarCategories = _carCategoryService.TGetListAll();
            ViewBag.CarCategoryList = new SelectList(CarCategories, "CarCategoryID", "CategoryName");

            var CarList = _carService.TGetListAll();
            var uniqueGearTypes = CarList.Select(c => c.GearType).Distinct().ToList();
            ViewBag.GeartypeList = new SelectList(uniqueGearTypes);

            var uniqueYear = CarList.Select(c => c.Year).Distinct().OrderBy(y => y).ToList();
            ViewBag.YearList = new SelectList(uniqueYear);


            return View();
        }

    }
}