using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.ServiceComponents
{
    public class _HowItWorksStepComponentPartial:ViewComponent
    {
        private readonly IHowItWorksStepService _howItWorksStepService;

        public _HowItWorksStepComponentPartial(IHowItWorksStepService howItWorksStepService)
        {
            _howItWorksStepService = howItWorksStepService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _howItWorksStepService.TGetListAll();
            return View(values);
        }
    }
}
