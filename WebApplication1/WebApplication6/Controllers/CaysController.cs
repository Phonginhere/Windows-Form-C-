using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class CaysController : Controller
    {
        private Model_Cay_Loai_Compound db = new Model_Cay_Loai_Compound();

        // GET: Cays
        public ActionResult Index()
        {
            var cay = db.Cay.Include(c => c.LoaiCays);
            return View(cay.ToList());
        }
        //Get: LoaiCays

        //public ActionResult IndexLc()
        //{
        //    return View("~/Views/LoaiCays/Index.cshtml");
        //}

        // GET: Cays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cay cay = db.Cay.Find(id);
            if (cay == null)
            {
                return HttpNotFound();
            }
            return View(cay);
        }

        // GET: Cays/Create
        public ActionResult Create()
        {
            ViewBag.LoaiCayId = new SelectList(db.LoaiCay, "LoaiCayId", "LoaiCayTen");
            return View();
        }

        // POST: Cays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CayId,CayTen,CayMoTa,LoaiCayId")] Cay cay)
        {
            if (ModelState.IsValid)
            {
                db.Cay.Add(cay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiCayId = new SelectList(db.LoaiCay, "LoaiCayId", "LoaiCayTen", cay.LoaiCayId);
            return View(cay);
        }

        // GET: Cays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cay cay = db.Cay.Find(id);
            if (cay == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiCayId = new SelectList(db.LoaiCay, "LoaiCayId", "LoaiCayTen", cay.LoaiCayId);
            return View(cay);
        }

        // POST: Cays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CayId,CayTen,CayMoTa,LoaiCayId")] Cay cay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiCayId = new SelectList(db.LoaiCay, "LoaiCayId", "LoaiCayTen", cay.LoaiCayId);
            return View(cay);
        }

        // GET: Cays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cay cay = db.Cay.Find(id);
            if (cay == null)
            {
                return HttpNotFound();
            }
            return View(cay);
        }

        // POST: Cays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cay cay = db.Cay.Find(id);
            db.Cay.Remove(cay);
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
