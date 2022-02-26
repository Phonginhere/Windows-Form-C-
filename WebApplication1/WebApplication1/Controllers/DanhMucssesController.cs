using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DanhMucssesController : Controller
    {
        private ModelSanPham db = new ModelSanPham();

        // GET: DanhMucsses
        public ActionResult Index()
        {
            return View(db.DanhMucsses.ToList());
        }

        // GET: DanhMucsses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucss danhMucss = db.DanhMucsses.Find(id);
            if (danhMucss == null)
            {
                return HttpNotFound();
            }
            return View(danhMucss);
        }

        // GET: DanhMucsses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMucsses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DanhMucsID,DanhMucName")] DanhMucss danhMucss)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucsses.Add(danhMucss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhMucss);
        }

        // GET: DanhMucsses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucss danhMucss = db.DanhMucsses.Find(id);
            if (danhMucss == null)
            {
                return HttpNotFound();
            }
            return View(danhMucss);
        }

        // POST: DanhMucsses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DanhMucsID,DanhMucName")] DanhMucss danhMucss)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(danhMucss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhMucss);
        }

        // GET: DanhMucsses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucss danhMucss = db.DanhMucsses.Find(id);
            if (danhMucss == null)
            {
                return HttpNotFound();
            }
            return View(danhMucss);
        }

        // POST: DanhMucsses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhMucss danhMucss = db.DanhMucsses.Find(id);
            db.DanhMucsses.Remove(danhMucss);
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
