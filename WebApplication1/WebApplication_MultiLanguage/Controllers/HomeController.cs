using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_MultiLanguage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index_vi_VN(string mylanguage)
        {
            String selectlanguage0 = this.Request.UserLanguages[0];
            String selectAgent0 = Request.UserAgent;
            try
            {
                String selectlanguage1 = this.Request.UserLanguages[1];
            }
            catch (Exception x)
            {

            }
            ViewBag.selectLanguage = selectlanguage0;
            ViewBag.UserAgent = selectAgent0;
            if (mylanguage.Contains("en")) { return View("Index_en_US"); }
            if (mylanguage.Contains("vi")) { return View("Index_vi_VN"); }
            return View();
        }
        [HttpGet]
        public ActionResult Index_en_US(string mylanguage)
        {
            String selectlanguage0 = this.Request.UserLanguages[0];
            String selectAgent0 = Request.UserAgent;
            try
            {
                String selectlanguage1 = this.Request.UserLanguages[1];
            }
            catch (Exception x)
            {

            }
            ViewBag.selectLanguage = selectlanguage0;
            ViewBag.UserAgent = selectAgent0;
            if (mylanguage.Contains("en")) { return View("Index_en_US"); }
            if (mylanguage.Contains("vi")) { return View("Index_vi_VN"); }
            return View();
        }
        public ActionResult Index(string mylanguage)
        {
           // String getLanguage = Request.UserLanguages[0];
            String selectlanguage0 = this.Request.UserLanguages[0];
            try
            {
               String selectlanguage1 = this.Request.UserLanguages[1];
            }catch(Exception x)
            {

            }
            @ViewBag.selectLanguage = selectlanguage0;
            if(mylanguage != null)
            {
                // if (selectlanguage0.Contains("en")) { return View("Index_en_US"); }

                //if (selectlanguage0.Contains("vi")) { return View("Index_vi_VN"); }
                if (mylanguage.Contains("en")) { return View("Index_en_US"); }

                if (mylanguage.Contains("vi")) { return View("Index_vi_VN"); }
            }

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
    }
}