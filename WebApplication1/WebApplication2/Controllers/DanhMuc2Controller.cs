using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DanhMuc2Controller : Controller
    {
        private Model_Product_Content db = new Model_Product_Content();

        // GET: DanhMuc2
        public ActionResult Index()
        {
            return View(db.DanhMucs.ToList());
        }

        // GET: DanhMuc2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc2 danhMuc2 = db.DanhMucs.Find(id);
            if (danhMuc2 == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc2);
        }

        // GET: DanhMuc2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMuc2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DanhMuc2ID,DanhMuc2Name")] DanhMuc2 danhMuc2)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucs.Add(danhMuc2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhMuc2);
        }

        // GET: DanhMuc2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc2 danhMuc2 = db.DanhMucs.Find(id);
            if (danhMuc2 == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc2);
        }

        // POST: DanhMuc2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DanhMuc2ID,DanhMuc2Name")] DanhMuc2 danhMuc2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhMuc2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhMuc2);
        }

        // GET: DanhMuc2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc2 danhMuc2 = db.DanhMucs.Find(id);
            if (danhMuc2 == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc2);
        }

        // POST: DanhMuc2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhMuc2 danhMuc2 = db.DanhMucs.Find(id);
            db.DanhMucs.Remove(danhMuc2);
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
