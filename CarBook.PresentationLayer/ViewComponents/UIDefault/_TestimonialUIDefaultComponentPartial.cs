using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _TestimonialUIDefaultComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialUIDefaultComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetListAll();
            return View(values);
        }
    }
}
