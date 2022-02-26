using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class SubjectMasController : Controller
    {
        private Model_Student_context db = new Model_Student_context();

        // GET: SubjectMas
        public ActionResult Index()
        {
            return View(db.SubjectMas.ToList());
        }

        // GET: SubjectMas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectMa subjectMa = db.SubjectMas.Find(id);
            if (subjectMa == null)
            {
                return HttpNotFound();
            }
            return View(subjectMa);
        }

        // GET: SubjectMas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectMas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectMaId,SubjectMaName")] SubjectMa subjectMa)
        {
            if (ModelState.IsValid)
            {
                db.SubjectMas.Add(subjectMa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subjectMa);
        }

        // GET: SubjectMas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectMa subjectMa = db.SubjectMas.Find(id);
            if (subjectMa == null)
            {
                return HttpNotFound();
            }
            return View(subjectMa);
        }

        // POST: SubjectMas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectMaId,SubjectMaName")] SubjectMa subjectMa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjectMa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subjectMa);
        }

        // GET: SubjectMas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectMa subjectMa = db.SubjectMas.Find(id);
            if (subjectMa == null)
            {
                return HttpNotFound();
            }
            return View(subjectMa);
        }

        // POST: SubjectMas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubjectMa subjectMa = db.SubjectMas.Find(id);
            db.SubjectMas.Remove(subjectMa);
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
