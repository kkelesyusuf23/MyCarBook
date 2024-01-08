using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIAbout
{
	public class _TeamUIAboutComponentPartial:ViewComponent
	{
		private readonly ITeamService _service;

		public _TeamUIAboutComponentPartial(ITeamService service)
		{
			_service = service;
		}

		public IViewComponentResult Invoke()
		{
			var values = _service.TGetListAll();
			return View(values);
		}
	}
}
