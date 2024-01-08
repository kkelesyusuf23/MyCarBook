using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIService
{
    public class _FeatureUIServiceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
