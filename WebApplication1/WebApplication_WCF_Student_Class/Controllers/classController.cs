using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_WCF_Student_Class.Controllers
{
    public class classController : Controller
    {
        // GET: class
        public ActionResult Index()
        {
            ServiceReference1.Service1Client cls_db = new ServiceReference1.Service1Client();
            return View(cls_db.getClass());
        }
    }
}