using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using static WebApplication2.Models.HomeController;

namespace WebApplication2.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public ActionResult Index()
        {
            return View();
        }
        SqlConnection con;

        public ActionResult SqlHome()
        {
            String connectionString = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=DB_Student;User ID=sa;Password=1234567;";
            con = new SqlConnection(connectionString);
            String sql = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(sql, con);

            var model = new List<Student>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var student = new Student();
                    student.studentName = rdr["studentName"].ToString();
                    student.studentEmail = rdr["studentEmail"].ToString();
                    student.studentPass = rdr["studentPass"].ToString();

                    model.Add(student);
                }
                con.Close();

            }

            return View(model);
        }
    }
}





