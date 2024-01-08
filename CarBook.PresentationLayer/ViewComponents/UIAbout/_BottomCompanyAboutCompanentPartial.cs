using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIAbout
{
	public class _BottomCompanyAboutCompanentPartial:ViewComponent
	{
		private readonly ICompanyService _companyService;

		public _BottomCompanyAboutCompanentPartial(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _companyService.GetCompanyforOurHistory();
			return View(value);
		}
	}
}
