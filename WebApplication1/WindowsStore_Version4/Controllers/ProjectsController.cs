using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WindowsStore_Version4.Models;

namespace WindowsStore_Version4.Controllers
{
    public class ProjectsController : Controller
    {
        private Model_Project_Context db = new Model_Project_Context();

        // GET: Projects
        public ActionResult Index(string status, string namecategory, string projectText)
        {
            //dropdown
            var nameCategory = typeof(Project).GetProperties().Select(n => n.Name);

            SelectList sl = new SelectList(nameCategory);

            ViewBag.catename = sl;

            //display table
            var projects = from p in db.Project select p;

            if (status == "đang thực hiện")
            {
                if (!(String.IsNullOrEmpty(projectText)))
                {
                    if (namecategory == "ProjectName")
                    {
                        projects = from p in db.Project where p.ProjectName.Contains(projectText) where p.ProjectEnd > DateTime.Now || p.ProjectEnd == null select p;
                    }
                    if (namecategory == "ProjectDescription")
                    {
                        projects = from p in db.Project where p.ProjectDescription.Contains(projectText) where p.ProjectEnd > DateTime.Now || p.ProjectEnd != null select p;
                    }
                    if (namecategory == "ProjectEnd")
                    {
                        projects = from p in db.Project where p.ProjectEnd == DateTime.Parse(projectText) where p.ProjectEnd > DateTime.Now || p.ProjectEnd == null select p;
                    }
                    if (namecategory == "ProjectStart")
                    {
                        projects = from p in db.Project where p.ProjectEnd == DateTime.Parse(projectText) where p.ProjectEnd > DateTime.Now || p.ProjectEnd == null select p;
                    }

                }
            }
            if (status == "đã hoàn thành")
            {
                if (!(String.IsNullOrEmpty(projectText)))
                {
                    if (namecategory == "ProjectName")
                    {
                        projects = from p in db.Project where p.ProjectName.Contains(projectText) where p.ProjectEnd < DateTime.Now || p.ProjectEnd == null select p;
                    }
                    if (namecategory == "ProjectDescription")
                    {
                        projects = from p in db.Project where p.ProjectDescription.Contains(projectText) where p.ProjectEnd < DateTime.Now || p.ProjectEnd == null select p;
                    }
                    if (namecategory == "ProjectEnd")
                    {
                        projects = from p in db.Project where p.ProjectEnd == DateTime.Parse(projectText) where p.ProjectEnd < DateTime.Now || p.ProjectEnd == null select p;
                    }
                    if (namecategory == "ProjectStart")
                    {
                        projects = from p in db.Project where p.ProjectEnd == DateTime.Parse(projectText) where p.ProjectEnd < DateTime.Now || p.ProjectEnd == null select p;
                    }
                }
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
