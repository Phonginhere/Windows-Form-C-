using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Windows_Store.Models;
using PagedList.Mvc;
namespace Windows_Store.Controllers
{
    public class ExamsController : Controller
    {
        private Model_Student_Exam_SubJect_Class_Context db = new Model_Student_Exam_SubJect_Class_Context();

        // GET: Exams
        //[HttpGet]
        //public ActionResult Index()
        //{
        //   // var exam = db.Exam.Include(e => e.Student).Include(e => e.Subject);
        //    return View();
        //}
        [HttpGet]
        public ActionResult Index()
        {
            var exam = db.Exam.Include(e => e.Student).Include(e => e.Subject);
            return View(exam.ToList());
        }
        [HttpPost]
        public ActionResult Index(string searchSubject, string searchStudent) 
        {
            //var exam = (dynamic)null;

            if (!String.IsNullOrEmpty(searchStudent))
            {
              var exam1 = db.Student.Where(s => s.StudentName.Contains(searchStudent));
                return View(exam1);
            }
            if (!String.IsNullOrEmpty(searchSubject))
            {
             var  exam2 = db.Subject.Where(s => s.SubjectName.Contains(searchSubject));
                return View(exam2);
            }

            //var exam = db.Exam.Include(e => e.Student).Include(e => e.Subject);
            //return View(exam.ToList());
            return View();
        }

        // GET: Exams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exam.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Exams/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName");
            ViewBag.SubjectId = new SelectList(db.Subject, "SubjectId", "SubjectName");
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExamId,SubjectId,StudentId,Mark")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Exam.Add(exam);
                db.SaveChanges();
                return RedirectToAction("Index");
                
            }

            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", exam.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subject, "SubjectId", "SubjectName", exam.SubjectId);
            TempData["AlertMessage"] = "Create succesfully ";
            return View(exam);
        }

        // GET: Exams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exam.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", exam.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subject, "SubjectId", "SubjectName", exam.SubjectId);
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExamId,SubjectId,StudentId,Mark")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", exam.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subject, "SubjectId", "SubjectName", exam.SubjectId);
            return View(exam);
        }

        // GET: Exams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exam.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exam exam = db.Exam.Find(id);
            db.Exam.Remove(exam);
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
