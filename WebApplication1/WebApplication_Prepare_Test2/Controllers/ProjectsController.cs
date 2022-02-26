using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_Prepare_Test2.Models;

namespace WebApplication_Prepare_Test2.Controllers
{
    public class ProjectsController : Controller
    {
        private Model_Project_Context db = new Model_Project_Context();

        // GET: Projects
        public ActionResult Index(string status, string dropdowncate, string name)
        {
            var listname = typeof(Project).GetProperties().Select(l => l.Name).Distinct();

            SelectList sl = new SelectList(listname);

            ViewBag.catename = sl;

            

            var projects = from p in db.Project select p;

            //select 
            if(dropdowncate == "ProjectName")
            {
                projects = from p in db.Project where p.ProjectName.Contains(name) select p;
            }
            try
            {
                if (dropdowncate == "ProjectStart")
                {
                    projects = from p in db.Project where p.ProjectStart == Convert.ToDateTime(name) select p;
                }
                if (dropdowncate == "ProjectEnd")
                {
                    projects = from p in db.Project where p.ProjectEnd.Equals(Convert.ToDateTime(name)) select p;
                }
            }catch(Exception e)
            {
                ViewBag.error = "Yeu cau nhap dung thoi gian MM/dd/yyyy";
            }
          
            if (dropdowncate == "ProjectDescription")
            {
                projects = from p in db.Project where p.ProjectDescription.Contains(name) select p;
            }

            if(status == "pass")
            {
                projects = from p in db.Project where p.ProjectEnd < DateTime.Now select p;
            }
            if (status == "wait")
            {
                projects = from p in db.Project where p.ProjectEnd > DateTime.Now select p;
            }

            return View(projects);
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Project.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,ProjectStart,ProjectEnd,ProjectDescription")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Project.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Project.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectName,ProjectStart,ProjectEnd,ProjectDescription")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Project.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Project.Find(id);
            db.Project.Remove(project);
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
