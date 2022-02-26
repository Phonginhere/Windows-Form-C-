using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using quản_lý_con_cua.Models;

namespace quản_lý_con_cua.Controllers
{
    public class cuaConsController : Controller
    {
        private Model1 db = new Model1();

        // GET: cuaCons
        public ActionResult Index()
        {
            var cuaCons = db.cuaCons.Include(c => c.cuaMe);
            return View(cuaCons.ToList());
        }

        // GET: cuaCons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaCon cuaCon = db.cuaCons.Find(id);
            if (cuaCon == null)
            {
                return HttpNotFound();
            }
            return View(cuaCon);
        }

        // GET: cuaCons/Create
        public ActionResult Create()
        {
            ViewBag.cuaMeId = new SelectList(db.cuaMes, "CuaMeId", "CuaMeName");
            return View();
        }

        // POST: cuaCons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cuaConId,cuaConSoLuong,cuaConMoTa,cuaMeId")] cuaCon cuaCon)
        {
            if (ModelState.IsValid)
            {
                db.cuaCons.Add(cuaCon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cuaMeId = new SelectList(db.cuaMes, "CuaMeId", "CuaMeName", cuaCon.cuaMeId);
            return View(cuaCon);
        }

        // GET: cuaCons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaCon cuaCon = db.cuaCons.Find(id);
            if (cuaCon == null)
            {
                return HttpNotFound();
            }
            ViewBag.cuaMeId = new SelectList(db.cuaMes, "CuaMeId", "CuaMeName", cuaCon.cuaMeId);
            return View(cuaCon);
        }

        // POST: cuaCons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cuaConId,cuaConSoLuong,cuaConMoTa,cuaMeId")] cuaCon cuaCon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuaCon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cuaMeId = new SelectList(db.cuaMes, "CuaMeId", "CuaMeName", cuaCon.cuaMeId);
            return View(cuaCon);
        }

        // GET: cuaCons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaCon cuaCon = db.cuaCons.Find(id);
            if (cuaCon == null)
            {
                return HttpNotFound();
            }
            return View(cuaCon);
        }

        // POST: cuaCons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cuaCon cuaCon = db.cuaCons.Find(id);
            db.cuaCons.Remove(cuaCon);
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
