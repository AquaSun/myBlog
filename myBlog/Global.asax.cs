
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using myBlog.Controllers;

namespace myBlog
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes (RouteCollection routes)
		{
			var namespaces = new[] { typeof(PostsController).Namespace };
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");

			routes.MapRoute ("Login", "login", new {controller = "Auth", action = "Login"}, namespaces);

			routes.MapRoute ("Home", "", new {controller = "Posts", action = "Index"}, namespaces);

		}

		public static void RegisterGlobalFilters (GlobalFilterCollection filters)
		{
			filters.Add (new HandleErrorAttribute ());
		}

		protected void Application_Start ()
		{
			AreaRegistration.RegisterAllAreas ();
			RegisterGlobalFilters (GlobalFilters.Filters);
			RegisterRoutes (RouteTable.Routes);
		}
	}
}
