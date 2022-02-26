using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Triangle.Controllers
{
    public class HomeController : Controller
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=QL_TamGiac;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataAdapter read;

        public ActionResult Triangle(string edge1, string edge2, string edge3, string status)
        {
            
            //try
            //{
                int edgeon = Convert.ToInt32(edge1);
                int edgetw = Convert.ToInt32(edge2);
                int edgeth = Convert.ToInt32(edge3);
                string sts = status;

                con = new SqlConnection(sql_con);
                String sql = "insert into triangle_math values(@tri_edge1, @tri_edge2, @tri_edge3, @tri_status)";
                exec = new SqlCommand(sql, con);
            
            exec.Parameters.AddWithValue("@tri_edge1", edgeon);
                exec.Parameters.AddWithValue("@tri_edge2", edgetw);
                exec.Parameters.AddWithValue("@tri_edge3", edgeth);
                exec.Parameters.AddWithValue("@tri_status", sts);

            con.Open();
            SqlDataReader read = exec.ExecuteReader();
                con.Close();
                if (read.Read())
                {
                    ViewBag.Sta = "Thành Công";
                }
                else
                {
                    ViewBag.Sta = "Thất Bại";
                }
            return View();
        }

            //catch(Exception e)
            //{
            //    ViewBag.Sta = e;
            //}
        


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