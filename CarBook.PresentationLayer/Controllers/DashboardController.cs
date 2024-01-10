using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class DashboardController : Controller
	{
		private readonly ICarService _carService;
		private readonly ICarRantService _carRantService;
		private readonly IPriceService _priceService;
		private readonly ICommentService _commentService;
		private readonly IBrandService _brandService;

		public DashboardController(ICarService carService, ICarRantService carRantService, IPriceService priceService, ICommentService commentService, IBrandService brandService)
		{
			_carService = carService;
			_carRantService = carRantService;
			_priceService = priceService;
			_commentService = commentService;
			_brandService = brandService;
		}

		public IActionResult Index()
		{
			ViewBag.carCount = _carService.TGetListAll().Count();
			ViewBag.TotalRantCarCount = _carRantService.TGetListAll().Count();
			ViewBag.TotalMonny = _priceService.TGetListAll().Sum(x => x.PriceValue);
			ViewBag.BrandCount = _brandService.TGetListAll().Count();

			var value = _commentService.TGetListAll().ToList();

			return View(value);
		}
	}
}
