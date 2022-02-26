using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class QuaTrung2Controller : Controller
    {
        private Model_GaTrung_Context db = new Model_GaTrung_Context();

        // GET: QuaTrung2
        public ActionResult Index()
        {
            var quaTrung = db.QuaTrung.Include(q => q.ConGa);
            return View(quaTrung.ToList());
        }

        // GET: QuaTrung2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuaTrung2 quaTrung2 = db.QuaTrung.Find(id);
            if (quaTrung2 == null)
            {
                return HttpNotFound();
            }
            return View(quaTrung2);
        }

        // GET: QuaTrung2/Create
        public ActionResult Create()
        {
            ViewBag.ConGa2Id = new SelectList(db.ConGa, "ConGa2Id", "ConGa2Name");
            return View();
        }

        // POST: QuaTrung2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuaTrung2Id,QuaTrung2Name,QuaTrung2Desc,ConGa2Id")] QuaTrung2 quaTrung2)
        {
            if (ModelState.IsValid)
            {
                db.QuaTrung.Add(quaTrung2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConGa2Id = new SelectList(db.ConGa, "ConGa2Id", "ConGa2Name", quaTrung2.ConGa2Id);
            return View(quaTrung2);
        }

        // GET: QuaTrung2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuaTrung2 quaTrung2 = db.QuaTrung.Find(id);
            if (quaTrung2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConGa2Id = new SelectList(db.ConGa, "ConGa2Id", "ConGa2Name", quaTrung2.ConGa2Id);
            return View(quaTrung2);
        }

        // POST: QuaTrung2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuaTrung2Id,QuaTrung2Name,QuaTrung2Desc,ConGa2Id")] QuaTrung2 quaTrung2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quaTrung2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConGa2Id = new SelectList(db.ConGa, "ConGa2Id", "ConGa2Name", quaTrung2.ConGa2Id);
            return View(quaTrung2);
        }

        // GET: QuaTrung2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuaTrung2 quaTrung2 = db.QuaTrung.Find(id);
            if (quaTrung2 == null)
            {
                return HttpNotFound();
            }
            return View(quaTrung2);
        }

        // POST: QuaTrung2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuaTrung2 quaTrung2 = db.QuaTrung.Find(id);
            db.QuaTrung.Remove(quaTrung2);
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
