using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class LoaiThuCungsController : Controller
    {
        private Model_Pet_Context db = new Model_Pet_Context();

        // GET: LoaiThuCungs
        public ActionResult Index()
        {
            return View(db.LoaiThuCung.ToList());
        }

        // GET: LoaiThuCungs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThuCung loaiThuCung = db.LoaiThuCung.Find(id);
            if (loaiThuCung == null)
            {
                return HttpNotFound();
            }
            return View(loaiThuCung);
        }

        // GET: LoaiThuCungs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiThuCungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiThuCungId,LoaiThuCungName,LoaiThuCungMota")] LoaiThuCung loaiThuCung)
        {
            if (ModelState.IsValid)
            {
                db.LoaiThuCung.Add(loaiThuCung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiThuCung);
        }

        // GET: LoaiThuCungs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThuCung loaiThuCung = db.LoaiThuCung.Find(id);
            if (loaiThuCung == null)
            {
                return HttpNotFound();
            }
            return View(loaiThuCung);
        }

        // POST: LoaiThuCungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoaiThuCungId,LoaiThuCungName,LoaiThuCungMota")] LoaiThuCung loaiThuCung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiThuCung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiThuCung);
        }

        // GET: LoaiThuCungs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThuCung loaiThuCung = db.LoaiThuCung.Find(id);
            if (loaiThuCung == null)
            {
                return HttpNotFound();
            }
            return View(loaiThuCung);
        }

        // POST: LoaiThuCungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiThuCung loaiThuCung = db.LoaiThuCung.Find(id);
            db.LoaiThuCung.Remove(loaiThuCung);
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
