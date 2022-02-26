using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LamToanController : Controller
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Pt_Bac2;User ID=sa;Password=1234567");
        SqlCommand exec;
        // GET: LamToan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LamToan1(String soA, String soB)
        {
            //ViewBag.a = soA;
            //ViewBag.b = soB;
            int a = Convert.ToInt32(soA);
            int b = Convert.ToInt32(soB);
            int c = a + b;

           
            ViewData["c"] = c;
            String cc = Convert.ToString(c);
            LamToan2(cc);
            if (cc != "0")
            {
                
                return View("~/Views/LamToan/LamToan2.cshtml");
            }
            return View("~/Views/LamToan/LamToan1.cshtml");
        }

        public ActionResult LamToan2(String soC)
        {
            ViewData["c"] = soC;

            return View();

        }
        public ActionResult GiaiPTBac2(String a, String b, String c)
        {
            double aa = Convert.ToDouble(a);
            double bb = Convert.ToDouble(b);
            double cc = Convert.ToDouble(c);

            GiaiPTBac2_KetQua(aa, bb, cc);

            return View();
        }
        public ActionResult GiaiPTBac2_KetQua(double a, double b, double c)
        {
            if (a == 0)
            {
                double ketqua = -c / b;
                ViewData["x1"] ="Nghiệm khuyết a có: "+ ketqua;
                String cmt = "Nghiem kep";

                //con.Open();
                //String sql = "INSERT INTO PtBac2_Table values ('" + a + "',N'" + b + "','" + c + "','" + ketqua + "', N'" + cmt + "')";
                //SqlCommand exec = new SqlCommand(sql, con);
                //exec.ExecuteReader();
                //con.Close();


            }
            else
            {
                double delta1 = Math.Pow(b, 2);
                double delta2 = 4 * a * c;
                double delta = delta1 - delta2;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ViewData["x1"] = x1;
                    ViewData["x2"] = x2;

                    //textBox1.Text = "Pt có 2 nghiệm: " + Convert.ToString(x1) + " và " + Convert.ToString(x2);
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    ViewData["x1"] ="Nghiệm kép: "+ x;

                    //textBox1.Text = "Pt có nghiệm kép: " + Convert.ToString(x);
                }
                else
                {
                    ViewData["vn"] = "Pt vô nghiệm";

                    //textBox1.Text = "Pt vô nghiệm";
                }
            }

            return View();
        }
        
    }
}