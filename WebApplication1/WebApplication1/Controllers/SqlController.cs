using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public ActionResult Index()
        {
            return View();
        }
        SqlConnection con;
        public ActionResult SqlShow()
        {
            List<Students> students = new List<Students>();
            //string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            String constr = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=DB_Student;User ID=sa;Password=1234567;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Students";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            students.Add(new Students
                            {
                                studentId = sdr["studentId"].ToString(),
                                studentName = sdr["studentName"].ToString(),
                                studentEmail = sdr["studentEmail"].ToString(),
                                studentPass = sdr["studentPass"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            ViewBag.Students = students;
            return View();
        }
    }
}