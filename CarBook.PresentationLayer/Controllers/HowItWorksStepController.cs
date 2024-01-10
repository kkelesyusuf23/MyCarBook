using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class HowItWorksStepController : Controller
	{
		private readonly IHowItWorksStepService _howItWorksStepService;

		public HowItWorksStepController(IHowItWorksStepService howItWorksStepService)
		{
			_howItWorksStepService = howItWorksStepService;
		}

		public IActionResult Index()
		{
			var values = _howItWorksStepService.TGetListAll();
			return View(values);
		}
	}
}
