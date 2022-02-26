using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_WCF_Student_Class_Practice1.Controllers
{
    public class ClassesController : Controller
    {
        // GET: Classes
        public ActionResult Index()
        {
            ServiceReference1.Service1Client db = new ServiceReference1.Service1Client();

            return View(db.GetClasses());
        }
    }
}