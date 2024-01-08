using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class UIContactController : Controller
	{
		private readonly IContactService _contactService;

		public UIContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			_contactService.TInsert(contact);
			return RedirectToAction("Index");
		}
	}
}
