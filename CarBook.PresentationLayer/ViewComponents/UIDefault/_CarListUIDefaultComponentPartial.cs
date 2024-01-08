using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _CarListUIDefaultComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _CarListUIDefaultComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetAllCarWithBrands();
            return View(values);
        }
    }
}
