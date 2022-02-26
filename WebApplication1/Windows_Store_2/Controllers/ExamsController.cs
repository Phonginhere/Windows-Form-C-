using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Windows_Store_2.Models;
using PagedList;

namespace Windows_Store_2.Controllers
{
    public class ExamsController : Controller
    {
        private Model_School_Context db = new Model_School_Context();

        // GET: Exams
        public ActionResult Index(String studentName, string subjectName, string compare, string filterValue, int? Page_no)
        {
            ViewBag.Success = TempData["Success"];


            //student
            var student_name = db.Student.Select(e => e.StudentName);

            SelectList sl_student = new SelectList(student_name);

            ViewBag.sn = sl_student;

            //subject
            var subject_name = db.Subject.Select(e => e.SubjectName).Distinct();

            SelectList sl_subject = new SelectList(subject_name);

            ViewBag.sns = sl_subject;

            //show table 

            var exam = from m in db.Exam select m;

            //compare

            if(compare == "pass")
            {
                ViewBag.suc = "Đỗ";
                exam = from m in db.Exam where m.Student.StudentName == studentName where m.Subject.SubjectName == subjectName where m.Mark >= 40 select m; 
            }

            if (compare == "fail")
            {
                ViewBag.suc = "Trượt";
                exam = from m in db.Exam where m.Student.StudentName == studentName where m.Subject.SubjectName == subjectName where m.Mark < 40 select m;

            }

            if (compare == "pass_fail")
            {
                exam = from m in db.Exam
                       where m.Student.StudentName == studentName
                       where m.Subject.SubjectName == subjectName
                       select m;
                ViewBag.suc = "Đỗ và Trượt";
            }

            exam = exam.OrderBy(e => e.ExamId);
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_no ?? 1);

            //exam = db.Exam.Include(e => e.Student).Include(e => e.Subject);

            return View(exam.ToPagedList(No_Of_Page, Size_Of_Page));
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
                TempData["Success"] = true;
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", exam.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subject, "SubjectId", "SubjectName", exam.SubjectId);
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
                TempData["Success"] = true;
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
            TempData["Success"] = true;
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
