using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumeneraCharGen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little about Numenera and this webapp...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Some contact info:";

            return View();
        }
    }
}