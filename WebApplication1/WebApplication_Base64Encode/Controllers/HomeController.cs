using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Base64Encode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Base64Convert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Base64Convert(String encode)
        {
            //encode 
            string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(encode));

            //decode 
            // string inputStr = Encoding.UTF8.GetString(Convert.FromBase64String(encodedStr));

            ViewBag.encoder = encodedStr;
            return View();
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

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
    }
}