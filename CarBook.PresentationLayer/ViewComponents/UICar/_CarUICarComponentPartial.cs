using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UICar
{
    public class _CarUICarComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _CarUICarComponentPartial(ICarService carService)
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
