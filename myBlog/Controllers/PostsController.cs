using System;
using System.Web.Mvc;
using System.Web.Mvc.Html.LinkExtensions;

namespace myBlog.Controllers
{
	public class PostsController : Controller
	{
		public ActionResult Index()
		{

			return View();
		}
	}
}

