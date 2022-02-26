using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=qlSV;User ID=sa;Password=1234567;");
        
        // GET: User
        public ActionResult Index()
        {
            String sql = "SELECT * FROM student";
            SqlCommand cmd = new SqlCommand(sql, con);
            // User u1 = new Models.User { id = 1, name = "Tue", address = "Doi Can", email = "tue@gmail.com", phoneNumber = "0912345678" };
            //User u2 = new Models.User { id = 2, name = "Phong", address = "Cau Giay", email = "phong@gmail.com", phoneNumber = "0312345678" };

            // userlist.Add(u1);
            // userlist.Add(u2);

            List<User> user = new List<User>();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();

            User temp;
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                temp = new User();
                temp.id = Convert.ToInt32(dt.Rows[j]["id"].ToString());
                temp.name = dt.Rows[j]["name"].ToString();
                temp.email = dt.Rows[j]["email"].ToString();
                temp.phoneNumber = dt.Rows[j]["phone"].ToString();

                user.Add(temp);
            }


            //var u = TempData["user"];
            //if(u != null && u.GetType() == typeof(User))
            //{
            //    User uu = (User)u;
            //    userlist.Add(uu);
            //}

            return View(user);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User u)
        {
            try
            {
                //TODO: Add insert logic here
                // int a = 0;
                // a++;

                // if (u.name.Length < 4)
                // {
                //     ViewBag.Loi = "tên ko được nhỏ hơn 4 kí tự";
                //     return View();
                // }
                // else
                // {
                //     ViewBag.Loi = "tên ok";
                // }
                // a++;
                // // FormCollection collection = new FormCollection();

                // String name = u.name;
                // String email = u.email;
                // String pass = u.phoneNumber;
                //// String address = u.address;

                // //userlist.Add(u);


          

               
                if (!ModelState.IsValid)
                {
                    return View();
                }
                else {
                    con.Open();
                    string query = "INSERT INTO student (name,email,phone) Values(@name,@email,@phone)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@name", u.name);
                    command.Parameters.AddWithValue("@email", u.email);
                    command.Parameters.AddWithValue("@phone", u.phoneNumber);

                    command.ExecuteNonQuery();
                    con.Close();
                    return RedirectToAction("Index");
                }

                //TempData["user"] = u;
                return View();
            }
            catch
            {
                
            }
            return View();
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
