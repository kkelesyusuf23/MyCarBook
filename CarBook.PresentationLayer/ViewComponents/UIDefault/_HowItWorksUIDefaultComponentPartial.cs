using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _HowItWorksUIDefaultComponentPartial:ViewComponent
    {
        private readonly IHowItWorksStepService _stepService;

		public _HowItWorksUIDefaultComponentPartial(IHowItWorksStepService stepService)
		{
			_stepService = stepService;
		}

		public IViewComponentResult Invoke()
        {
            var values = _stepService.TGetFirst5Steps();
            return View(values);
        }
    }
}
