using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIService
{
    public class _ServiceUIServiceComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServiceUIServiceComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
    }
}
