using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {

            return View();
        }
       
        public ActionResult LamToan1(string soA, string soB, string YourRadioButton)
        {
            try
            {
                long a = Convert.ToInt64(soA);
                long b = Convert.ToInt64(soB);

                if (YourRadioButton == "plus")
                {
                    long c = a + b;
                    ViewData["c"] = Convert.ToString(c);
                }
                else if (YourRadioButton == "minus")
                {
                    long c = a - b;
                    ViewData["c"] = Convert.ToString(c);

                }
                else if (YourRadioButton == "mult")
                {
                    long c = a * b;
                    ViewData["c"] = Convert.ToString(c);

                }
                else if (YourRadioButton == "divi")
                {
                    double c = a / b;
                    ViewData["c"] = Convert.ToString(c);
                }
                else
                {
                    ViewData["cau"] = "Xin mời bạn bấm vào 4 nút";
                }
            }
            catch
            {
                ViewData["err"] = "Lỗi khi không nhập vào";
            }
            
            return View();
        }
     
    }
}