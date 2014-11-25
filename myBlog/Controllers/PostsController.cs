using System;
using System.Web.Mvc;

namespace myBlog.Controllers
{
	public class PostsController : Controller
	{
		public ActionResult Index()
		{
			return Content ("Hello World");
		}
	}
}

