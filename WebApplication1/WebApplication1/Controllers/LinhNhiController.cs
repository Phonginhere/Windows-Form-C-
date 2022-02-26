using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LinhNhiController : Controller
    {
        // GET: LinhNhi
        public ActionResult Index()
        {
            return View();
        }
        public String GetNhi(String Id)
        {
            String m = Id;
            int a = 0;
            a++;
            return "<p style='color: red'>Cộng Hòa xã hội chủ nghĩa Việt Nam</p> Id: " +Id;
        }
        public String GetNhi2(String Id, String name)
        {
            String abc = Request.Params[""];
            String m = Id;
            int a = 0;
            a++;
            Response.AppendHeader("abcd", "abcd_value");
            HttpCookie ck = new HttpCookie("ab", "abcd_value");
            Response.AppendCookie(new HttpCookie("mamaychu", "09890"));
            return "<p style='color: red'>Cộng Hòa xã hội chủ nghĩa Việt Nam</p> Id: " + Id +", name: " + name;
        }
    }
}