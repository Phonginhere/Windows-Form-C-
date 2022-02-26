using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        
        public ActionResult Create()
        {
            //ViewBag.Message = "Your contact page.";
            // string key = "DemoCookie";
            //HttpCookie MyCookie = new HttpCookie("LastVisit");

            //DateTime now = DateTime.Now;
            //MyCookie.Value = now.ToString();
            //MyCookie.Expires = now.AddHours(1);

            this.Response.Cookies["DaylaSanPham"].Value = "Điện thoại";


            DateTime dt = DateTime.Now;
            this.Response.Cookies["DaylaSanPham"].Expires = dt.AddDays(1);

            //Response.Cookies.Add(MyCookie);
            //Response.Cookies.

            return View();
            }
        }
    }