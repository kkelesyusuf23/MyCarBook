using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UICar
{
    public class _FeatureUICarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
