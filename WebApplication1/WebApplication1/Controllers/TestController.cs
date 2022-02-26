using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetTest()
        {
            return View();
        }
        public ActionResult GetKey(String mota)
        {
            String myname = mota;
            int i = 0;
            i++;
            ViewBag.mota = myname;
            return View();

        }
    }
}