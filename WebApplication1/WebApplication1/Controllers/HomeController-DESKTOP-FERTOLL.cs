using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //kế thừa thì phái chứa tên là controller
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Customer customer = new Customer();
            ViewBag.Header = "Customer Details";
            return View(customer);   
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

