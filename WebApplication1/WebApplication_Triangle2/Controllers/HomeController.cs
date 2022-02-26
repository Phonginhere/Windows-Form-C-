using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Triangle2.Controllers
{
    public class HomeController : Controller
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=QL_TamGiac;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataAdapter ada;

        public ActionResult View_Input(string edge1, string edge2, string edge3, string status)
        {
            int edgeo = Convert.ToInt32(edge1);
            int edgetw = Convert.ToInt32(edge2);
            int edgeth = Convert.ToInt32(edge3);
            string sts = status;
            ViewBag.Sta = sts;
            con = new SqlConnection(sql_con);
            String sql = "insert into triangle_math values(@tri_edge1, @tri_edge2, @tri_edge3, @tri_status)";
            exec = new SqlCommand(sql, con);

            exec.Parameters.AddWithValue("@tri_edge1", edgeo);
            exec.Parameters.AddWithValue("@tri_edge2", edgetw);
            exec.Parameters.AddWithValue("@tri_edge3", edgeth);
            exec.Parameters.AddWithValue("@tri_status", ""+sts+"");
            //exec.Parameters.Add("@lname", SqlDbType.VarChar).Value = string.IsNullOrEmpty(status) ? (object)DBNull.Value : status;

            con.Open();
            exec.ExecuteNonQuery();
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