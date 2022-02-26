using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public class Students
        {
            public int studentId { get; set; }
            public string studentName { get; set; }
            public string studentEmail { get; set; }
            public string studentPass { get; set; }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}