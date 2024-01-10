using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var valeus = _commentService.TGetListAll(); 
            return View(valeus);
        }
		public IActionResult DeleteComment(int id)
		{
			var values = _commentService.TGetById(id);
			_commentService.TDelete(values);
			return RedirectToAction("Index");
		}
	}
}
