using CarBook.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _ServicesUIDefaultComponentPartial:ViewComponent
    {
        private readonly IServiceDal _serviceDal;

        public _ServicesUIDefaultComponentPartial(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceDal.GetFirst3Service();
            return View(values);
        }
    }
}
