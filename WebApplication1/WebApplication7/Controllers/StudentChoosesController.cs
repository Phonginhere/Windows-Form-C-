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
    public class StudentChoosesController : Controller
    {
        private Model_Student_context db = new Model_Student_context();

        // GET: StudentChooses
        public ActionResult Index()
        {
            var studentChooses = db.StudentChooses.Include(s => s.Student).Include(s => s.SubjectMa);
            return View(studentChooses.ToList());
        }

        // GET: StudentChooses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentChoose studentChoose = db.StudentChooses.Find(id);
            if (studentChoose == null)
            {
                return HttpNotFound();
            }
            return View(studentChoose);
        }

        // GET: StudentChooses/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "StudentName");
            ViewBag.SubjectMaId = new SelectList(db.SubjectMas, "SubjectMaId", "SubjectMaName");
            return View();
        }

        // POST: StudentChooses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentChooseId,StudentId,SubjectMaId,Diem")] StudentChoose studentChoose)
        {
            if (ModelState.IsValid)
            {
                db.StudentChooses.Add(studentChoose);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "StudentName", studentChoose.StudentId);
            ViewBag.SubjectMaId = new SelectList(db.SubjectMas, "SubjectMaId", "SubjectMaName", studentChoose.SubjectMaId);
            return View(studentChoose);
        }

        // GET: StudentChooses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentChoose studentChoose = db.StudentChooses.Find(id);
            if (studentChoose == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "StudentName", studentChoose.StudentId);
            ViewBag.SubjectMaId = new SelectList(db.SubjectMas, "SubjectMaId", "SubjectMaName", studentChoose.SubjectMaId);
            return View(studentChoose);
        }

        // POST: StudentChooses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentChooseId,StudentId,SubjectMaId,Diem")] StudentChoose studentChoose)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentChoose).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "StudentName", studentChoose.StudentId);
            ViewBag.SubjectMaId = new SelectList(db.SubjectMas, "SubjectMaId", "SubjectMaName", studentChoose.SubjectMaId);
            return View(studentChoose);
        }

        // GET: StudentChooses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentChoose studentChoose = db.StudentChooses.Find(id);
            if (studentChoose == null)
            {
                return HttpNotFound();
            }
            return View(studentChoose);
        }

        // POST: StudentChooses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentChoose studentChoose = db.StudentChooses.Find(id);
            db.StudentChooses.Remove(studentChoose);
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
