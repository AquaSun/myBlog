using System.Web.Mvc;

namespace myBlog.Areas.Admin.Controllers
{
	public class UsersController : Controller
	{
		public ActionResult Index()
		{
			return Content ("USERS!");
		}
	}
}

