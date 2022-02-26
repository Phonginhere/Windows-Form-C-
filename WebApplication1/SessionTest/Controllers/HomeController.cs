using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["SessionEx"] = "This is TempData Example";

            return RedirectToAction("TempDataEx");

        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult TempDataEx()
        {
            Session["SessionEx"] = "This is TempData Example";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}