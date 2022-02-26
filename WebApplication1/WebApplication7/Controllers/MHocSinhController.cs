using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class MHocSinhController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getStudent()
        {
            var ob = new { name = "Hello Hải Anh", age = 30 };
            return Json(ob, JsonRequestBehavior.AllowGet);
        }

    }
}