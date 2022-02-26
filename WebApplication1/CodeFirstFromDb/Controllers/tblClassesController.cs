using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstFromDb;

namespace CodeFirstFromDb.Controllers
{
    public class tblClassesController : Controller
    {
        private ModelCodeFirstFromDB db = new ModelCodeFirstFromDB();

        // GET: tblClasses
        public ActionResult Index()
        {
            return View(db.tblClasses.ToList());
        }

        // GET: tblClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClass tblClass = db.tblClasses.Find(id);
            if (tblClass == null)
            {
                return HttpNotFound();
            }
            return View(tblClass);
        }

        // GET: tblClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop,SiSo")] tblClass tblClass)
        {
            if (ModelState.IsValid)
            {
                db.tblClasses.Add(tblClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblClass);
        }

        // GET: tblClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClass tblClass = db.tblClasses.Find(id);
            if (tblClass == null)
            {
                return HttpNotFound();
            }
            return View(tblClass);
        }

        // POST: tblClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop,SiSo")] tblClass tblClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblClass);
        }

        // GET: tblClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClass tblClass = db.tblClasses.Find(id);
            if (tblClass == null)
            {
                return HttpNotFound();
            }
            return View(tblClass);
        }

        // POST: tblClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblClass tblClass = db.tblClasses.Find(id);
            db.tblClasses.Remove(tblClass);
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
