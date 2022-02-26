using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WindowsStore_Version4.Models;

namespace WindowsStore_Version4.Controllers
{
    public class AssignTasksController : Controller
    {
        private Model_Project_Context db = new Model_Project_Context();

        // GET: AssignTasks
        public ActionResult Index(string name, string ddcpy, string ddclt)
        {
            //dropdown
            var listcate = typeof(AssignTask).GetProperties().Select(a => a.Name).Distinct();

            SelectList sl0 = new SelectList(listcate);

            ViewBag.catename = sl0;

            var listclt = db.Client.Select(c => c.ClientCompany).Distinct();

            SelectList sl = new SelectList(listclt);

            ViewBag.comname = sl;

            var listcp = db.Employee.Select(e => e.EmployeeDepartment).Distinct();

            SelectList sl1 = new SelectList(listcp);

            ViewBag.depname = sl1;

            //display table
            db.AssignTask.ToList();
            db.Client.ToList();
            db.Employee.ToList();
            db.Project.ToList();

            var assignTask = from a in db.AssignTask select a;

            // search name
            if (!(String.IsNullOrEmpty(name)))
            {
                assignTask = from a in db.AssignTask where a.Client.ClientName.Contains(name) || a.Employee.EmployeeName.Contains(name) || a.Project.ProjectName.Contains(name) || a.Task.Contains(name) || a.Note.Contains(name) select a;
            }
            

            // search dropdown
            if (!(String.IsNullOrEmpty(ddcpy)))
            {
                assignTask = from a in db.AssignTask where a.Client.ClientCompany.Equals(ddcpy) select a;
            }
            if (!(String.IsNullOrEmpty(ddclt)))
            {
                assignTask = from a in db.AssignTask where a.Employee.EmployeeDepartment.Equals(ddclt) select a;
            }
            if(!(String.IsNullOrEmpty(ddclt)) && !(String.IsNullOrEmpty(ddcpy)))
            {
                assignTask = from a in db.AssignTask where a.Employee.EmployeeDepartment.Equals(ddclt) && a.Client.ClientCompany.Equals(ddcpy) select a;
            }


            //&& (a.Client.ClientName.Contains(name) )
            //(a.Client.ClientName.Contains(name) || a.Employee.EmployeeName.Contains(name) || a.Project.ProjectName.Contains(name) || a.Task.Contains(name) || a.Note.Contains(name)) &&
            //(a.Client.ClientName.Contains(name) || a.Employee.EmployeeName.Contains(name) || a.Project.ProjectName.Contains(name) || a.Task.Contains(name) || a.Note.Contains(name)) && a.Employee.EmployeeDepartment.Equals(ddclt) &&

            // search text and dropdown

            if (!(String.IsNullOrEmpty(name)) && !(String.IsNullOrEmpty(ddclt)))
            {
                assignTask = from a in db.AssignTask where a.Employee.EmployeeDepartment.Equals(ddclt) 
                             && (a.Client.ClientName.Contains(name) 
                             || a.Employee.EmployeeName.Contains(name) 
                             || a.Project.ProjectName.Contains(name) 
                             || a.Task.Contains(name) || a.Note.Contains(name)) select a;
            }
            if (!(String.IsNullOrEmpty(name)) && !(String.IsNullOrEmpty(ddcpy)))
            {
                assignTask = from a in db.AssignTask where a.Client.ClientCompany.Equals(ddcpy) 
                             && (a.Client.ClientName.Contains(name)
                             || a.Employee.EmployeeName.Contains(name)
                             || a.Project.ProjectName.Contains(name)
                             || a.Task.Contains(name) || a.Note.Contains(name))
                             select a;
            }
            if (!(String.IsNullOrEmpty(name)) && !(String.IsNullOrEmpty(ddclt)) && !(String.IsNullOrEmpty(ddcpy)))
            {
                assignTask = from a in db.AssignTask where a.Client.ClientCompany.Equals(ddcpy) 
                             && a.Employee.EmployeeDepartment.Equals(ddclt)
                              && (a.Client.ClientName.Contains(name)
                             || a.Employee.EmployeeName.Contains(name)
                             || a.Project.ProjectName.Contains(name)
                             || a.Task.Contains(name) || a.Note.Contains(name))
                             select a;
            }

            return View(assignTask);
        }

        // GET: AssignTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignTask assignTask = db.AssignTask.Find(id);
            if (assignTask == null)
            {
                return HttpNotFound();
            }
            return View(assignTask);
        }

        // GET: AssignTasks/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "ClientName");
            ViewBag.EmployeeId = new SelectList(db.Employee, "EmployeeId", "EmployeeName");
            ViewBag.ProjectId = new SelectList(db.Project, "ProjectId", "ProjectName");
            return View();
        }

        // POST: AssignTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignTaskId,EmployeeId,ClientId,ProjectId,Task,Note")] AssignTask assignTask)
        {
            if (ModelState.IsValid)
            {
                db.AssignTask.Add(assignTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "ClientName", assignTask.ClientId);
            ViewBag.EmployeeId = new SelectList(db.Employee, "EmployeeId", "EmployeeName", assignTask.EmployeeId);
            ViewBag.ProjectId = new SelectList(db.Project, "ProjectId", "ProjectName", assignTask.ProjectId);
            return View(assignTask);
        }

        // GET: AssignTasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignTask assignTask = db.AssignTask.Find(id);
            if (assignTask == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "ClientName", assignTask.ClientId);
            ViewBag.EmployeeId = new SelectList(db.Employee, "EmployeeId", "EmployeeName", assignTask.EmployeeId);
            ViewBag.ProjectId = new SelectList(db.Project, "ProjectId", "ProjectName", assignTask.ProjectId);
            return View(assignTask);
        }

        // POST: AssignTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignTaskId,EmployeeId,ClientId,ProjectId,Task,Note")] AssignTask assignTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "ClientName", assignTask.ClientId);
            ViewBag.EmployeeId = new SelectList(db.Employee, "EmployeeId", "EmployeeName", assignTask.EmployeeId);
            ViewBag.ProjectId = new SelectList(db.Project, "ProjectId", "ProjectName", assignTask.ProjectId);
            return View(assignTask);
        }

        // GET: AssignTasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignTask assignTask = db.AssignTask.Find(id);
            if (assignTask == null)
            {
                return HttpNotFound();
            }
            return View(assignTask);
        }

        // POST: AssignTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssignTask assignTask = db.AssignTask.Find(id);
            db.AssignTask.Remove(assignTask);
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
