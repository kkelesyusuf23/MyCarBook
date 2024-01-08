using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIContact
{
	public class _ComtactInfoUIContactComponentPartial:ViewComponent
	{
		private readonly IContactInfoService _contactInfoService;

		public _ComtactInfoUIContactComponentPartial(IContactInfoService contactInfoService)
		{
			_contactInfoService = contactInfoService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _contactInfoService.TGetListAll();
			return View(values);
		}
	}
}
