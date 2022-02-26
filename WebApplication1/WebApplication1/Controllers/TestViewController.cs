using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestView
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayData(String name, String email, String phone)
        {
           
            return View();
            
        }
        public ActionResult DisplayData2(String name, String email, String phone)
        {
            //return View("~/Views/Login_SignUp/GetSignUp.cshtml");
            ViewData["mykey00"] = name;
            ViewData["mykey01"] = email;
            ViewData["mykey02"] = phone;
            //ViewBag.Name = name;
            //ViewBag.Email = email;
            return View();
        }
        public ActionResult DisplayData3()
        {
            return Redirect("Login_SignUp/GetLogin.cshtml");
        }
        List<String> getListName()
        {
            List<String> List = new List<string>() {
                "Chiều nay gió rét hun hun",
                "Bầm ra ruộng cấy bầm run ",
                "Chân lội dưới bùn tay cấy mạ non" ,
                "Mạ non bầm cấy mấy đon" ,
                "Tfvsdf" ,"ggg","b" ,"b" ,
                "b" };

            List<String> List2 = new List<string>();
            for (var i = 0; i < List.Count; i++)
            {
                if (List[i].Contains("Bầm") || List[i].Contains("bầm")) ;
                List2.Add(List[i]);
            }
            return List2;
        }
    }
}