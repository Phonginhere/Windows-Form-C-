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
    public class LoaiCaysController : Controller
    {
        private Model_Cay_Loai_Compound db = new Model_Cay_Loai_Compound();

       

        // GET: LoaiCays
        public ActionResult Index()
        {
            return View(db.LoaiCay.ToList());
        }

        // GET: LoaiCays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiCay loaiCay = db.LoaiCay.Find(id);
            if (loaiCay == null)
            {
                return HttpNotFound();
            }
            return View(loaiCay);
        }

        // GET: LoaiCays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiCays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiCayId,LoaiCayTen,LoaiCayMoTa")] LoaiCay loaiCay)
        {
            if (ModelState.IsValid)
            {
                db.LoaiCay.Add(loaiCay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiCay);
        }

        // GET: LoaiCays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiCay loaiCay = db.LoaiCay.Find(id);
            if (loaiCay == null)
            {
                return HttpNotFound();
            }
            return View(loaiCay);
        }

        // POST: LoaiCays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoaiCayId,LoaiCayTen,LoaiCayMoTa")] LoaiCay loaiCay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiCay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiCay);
        }

        // GET: LoaiCays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiCay loaiCay = db.LoaiCay.Find(id);
            if (loaiCay == null)
            {
                return HttpNotFound();
            }
            return View(loaiCay);
        }

        // POST: LoaiCays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiCay loaiCay = db.LoaiCay.Find(id);
            db.LoaiCay.Remove(loaiCay);
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
