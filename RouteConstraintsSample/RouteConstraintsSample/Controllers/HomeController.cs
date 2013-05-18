using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteConstraintsSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult IndexA()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult IndexC()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
