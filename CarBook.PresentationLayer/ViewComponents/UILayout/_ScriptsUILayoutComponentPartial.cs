using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UILayout
{
    public class _ScriptsUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
