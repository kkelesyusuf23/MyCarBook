using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class TeamController : Controller
	{
		private readonly ITeamService _service;

		public TeamController(ITeamService service)
		{
			_service = service;
		}

		public IActionResult Index()
		{
			var values = _service.TGetListAll();
			return View(values);
		}
	}
}
