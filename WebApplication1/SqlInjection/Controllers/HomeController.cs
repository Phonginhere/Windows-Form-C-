using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        String sql_con_str = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=SqlInjection;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlDataReader read;
        SqlCommand exec;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String userName, String UserPass)
        {
            con = new SqlConnection(sql_con_str);
            String sql = "select * from User_Table where username = @username and userpass = @userpass";
            String sql_hack = "select * from User_Table where username = '"+userName+ "' and userpass = '" + UserPass + "'";
            //exec = new SqlCommand(sql, con);
            exec = new SqlCommand(sql_hack, con);
            con.Open();
            //exec.Parameters.AddWithValue("@username", userName);
            //exec.Parameters.AddWithValue("@userpass", UserPass);
            SqlDataReader result = exec.ExecuteReader();
            

            if (result.Read())
            {
                ViewBag.Successful = "Thành Công";
                
            }else
            {
                ViewBag.Fail = "Thất Bại";
            }
            con.Close();
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