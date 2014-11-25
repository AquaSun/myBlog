using System.Web.Mvc;

namespace myBlog.Areas.Admin.Controllers
{
	public class PostsController : Controller
	{
		public ActionResult Index()
		{
			return Content ("Posts!");
		}
	}
}

