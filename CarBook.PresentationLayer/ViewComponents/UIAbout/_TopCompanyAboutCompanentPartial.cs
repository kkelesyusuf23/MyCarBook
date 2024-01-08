using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIAbout
{
	public class _TopCompanyAboutCompanentPartial:ViewComponent
	{
		private readonly ICompanyService _companyService;

		public _TopCompanyAboutCompanentPartial(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _companyService.GetCompanyforCarCompany();
			return View(value);
		}
	}
}
