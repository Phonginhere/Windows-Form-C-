using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Language_Religion.Controllers
{
    public class HomeController : Controller
    {
         SqlConnection con;
         SqlDataReader read;
         SqlCommand exec;
         String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=QL_Language_Religion;User ID=sa;Password=1234567";

        public ActionResult ShowLanguage()
        {
            ArrayList list = new ArrayList();

            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (CultureInfo culture in cinfo)
            {
                list.Add(String.Format("culture name{0} : Display name{1}", culture.Name, culture.DisplayName));
            }


            ViewBag.MyList = list;
            //Console.WriteLine(i + "##" + m.ToString());

            return View();
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