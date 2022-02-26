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
using UploadDb_NameImage.Models;

namespace UploadDb_NameImage.Controllers
{
    public class ImagesController : Controller
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=DB_Image;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;

        private Model_Img_Context db = new Model_Img_Context();

        // GET: Images
        public ActionResult Index_Customer()
        {
            return View(db.Image.ToList());
        }

        // GET: Images
        public ActionResult Index()
        {
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
        public ActionResult Create(HttpPostedFileBase ImagePath)
        {
            Image image = null;
            if (ModelState.IsValid)
            {
                //save vao folder
                string path = Path.Combine(Server.MapPath("~/ImageUpload"), Path.GetFileName(ImagePath.FileName));
                ImagePath.SaveAs(path);

                con = new SqlConnection(sql_con);
                String sql = "Insert Into Images values(@ImagePath)";
                exec = new SqlCommand(sql, con);

                exec.Parameters.AddWithValue("@ImagePath", ImagePath.FileName);

                con.Open();
                exec.ExecuteNonQuery();
                con.Close();

                //db.Image.Add(new Image
                //{
                //    ImageId = image.ImageId,
                //    ImagePath = "~/ImageUpload/" + ImagePath.FileName
                //});

                //luu vao trong db
                db.SaveChanges();
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
        public ActionResult Edit([Bind(Include = "ImageId,ImagePath")] Image image)
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
