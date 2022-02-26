using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            List<Users> user = new List<Users>();
            Users u1 = new Models.Users { UserId= 1, UserName = "Tue", UserEmail = "tue@gmail.com", UserPass = "12345" };
            Users u2 = new Models.Users { UserId = 2, UserName = "Phong", UserEmail = "phong@gmail.com", UserPass = "abcde" };
            user.Add(u1);
            user.Add(u2);
            var u = TempData["user"];
            if (u != null && u.GetType() == typeof(Users))
            {
                Users uu = (Users)u;
                user.Add(uu);
            }

            return View(user);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            
            try
            {
                // TODO: Add insert logic here
                Users u = new Users();
                u.UserId = Convert.ToInt32(collection["UserId"]);
                u.UserName = collection["UserName"];
                u.UserEmail = collection["UserEmail"];
                u.UserPass = collection["UserPass"];

                TempData["user"] = u;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
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

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
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
