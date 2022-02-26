using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Insert_Ajax.Models;
using System.Data;

namespace WebApplication_Insert_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult AddTriangle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTriangle(Triangle tri)
        {
            AddTriEdge(tri);
            return View();
        }

        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=AddTri;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;

        public void AddTriEdge(Triangle tri)
        {
            con = new SqlConnection(sql_con);
            exec = new SqlCommand("AddEmp", con);
            exec.CommandType = CommandType.StoredProcedure;
            exec.Parameters.AddWithValue("@Edge1", tri.Edge1);
            exec.Parameters.AddWithValue("@Edge2", tri.Edge2);
            exec.Parameters.AddWithValue("@Edge3", tri.Edge3);
            exec.Parameters.AddWithValue("@Tri_Status", tri.Tri_Status);
            con.Open();
            exec.ExecuteNonQuery();
            con.Close();
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