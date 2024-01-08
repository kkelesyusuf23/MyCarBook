using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIContact
{
	public class _FeatureUIContactComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
