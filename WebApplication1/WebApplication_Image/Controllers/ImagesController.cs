using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_Image.Models;

namespace WebApplication_Image.Controllers
{
    public class ImagesController : Controller
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Db_Image_Prepare;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;
        private Model_Image_Context db = new Model_Image_Context();

        // GET: Images
        public ActionResult Index()
        {
            TempData["AlertSuccesful"] = "Thanh Cong";
            return View(db.Image.ToList());
        }

        // GET: Images/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(String ImageName, string ImageDesc, HttpPostedFileBase ImagePath)
        {
            Image image = null;
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Server.MapPath("~/ImageFolder"), Path.GetFileName(ImagePath.FileName));
                ImagePath.SaveAs(path);

                con = new SqlConnection(sql_con);
                String sql = "Insert into Images values(@ImageName, @ImageDesc, @ImagePath)";
                exec = new SqlCommand(sql, con);
                exec.Parameters.AddWithValue("@ImageName", ImageName);
                exec.Parameters.AddWithValue("@ImageDesc", ImageDesc);
                exec.Parameters.AddWithValue("@ImagePath", "~/ImageFolder/" + ImagePath.FileName);
                con.Open();
                int a = exec.ExecuteNonQuery();
                con.Close();
                if (a > 0)
                {
                    TempData["AlertSuccesful"] = "Thanh Cong";
                }
                else
                {
                    TempData["AlertFail"] = "That Bai";
                }

                return RedirectToAction("Index");
            }

            return View(image);
        }

        // GET: Images/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ImageId,ImageName,ImageDesc,ImagePath")] Image image)
        {
            if (ModelState.IsValid)
            {
                db.Entry(image).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(image);
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Image image = db.Image.Find(id);
            db.Image.Remove(image);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
