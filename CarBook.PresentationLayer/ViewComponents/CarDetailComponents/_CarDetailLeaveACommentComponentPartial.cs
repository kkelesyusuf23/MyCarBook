using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailLeaveACommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
