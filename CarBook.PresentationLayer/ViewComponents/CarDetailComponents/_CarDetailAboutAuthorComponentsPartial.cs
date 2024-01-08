using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailAboutAuthorComponentsPartial:ViewComponent
    {
        private readonly ICarDetailService _carDetailService;

        public _CarDetailAboutAuthorComponentsPartial(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _carDetailService.TGetCarDetailWithAuthor(id);
            return View(values);
        }
    }
}
