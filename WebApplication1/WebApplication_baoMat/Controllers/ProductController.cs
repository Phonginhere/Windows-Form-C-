using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_baoMat.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Baomat1()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Baomat2()
        {
            return View();
        }
        public ActionResult Baomat3()
        {
            return View();
        }
    }
}