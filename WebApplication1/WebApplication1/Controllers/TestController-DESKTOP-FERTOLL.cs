using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        ModelTest mt = new ModelTest();
        // GET: Test
        public ActionResult Index()
        {
            var ii = mt.tblClasses;
            ViewData.Model = ii;

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
        // GET: SanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}