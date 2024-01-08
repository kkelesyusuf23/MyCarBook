using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCommentCmponentsPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CarDetailCommentCmponentsPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByCar(id);
            return View(values);
        }
    }
}
