using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class ContactInfoController : Controller
	{
		private readonly IContactInfoService _contactInfoService;

		public ContactInfoController(IContactInfoService contactInfoService)
		{
			_contactInfoService = contactInfoService;
		}

		public IActionResult Index()
		{
			var values = _contactInfoService.TGetListAll();
			return View(values);
		}
	}
}
