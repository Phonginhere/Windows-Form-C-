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
    public class EmployeesController : Controller
    {
        private Model_Project_Context db = new Model_Project_Context();

        // GET: Employees
        public ActionResult Index(string namecate, string textboxName)
        {
            ////dropdown
            var nameCategory = typeof(Employee).GetProperties().Select(e => e.Name);

            SelectList sl = new SelectList(nameCategory);

            ViewBag.catename = sl;


            //display table
            var display_employee = from m in db.Employee select m;

            //text
            if (!String.IsNullOrEmpty(textboxName))
            {
                if(namecate == "EmployeeName")
                {
                    display_employee = from m in db.Employee where m.EmployeeName.Contains(textboxName) select m;
                }
                if (namecate == "EmployeeDepartment")
                {
                    display_employee = from m in db.Employee where m.EmployeeDepartment.Contains(textboxName) select m;
                }
                if (namecate == "EmployeeEmail")
                {
                    display_employee = from m in db.Employee where m.EmployeeEmail.Contains(textboxName) select m;
                }
                if (namecate == "EmployeeName")
                {
                    display_employee = from m in db.Employee where m.EmployeeName.Contains(textboxName) select m;
                }
                if (namecate == "EmployeePhone")
                {
                    display_employee = from m in db.Employee where m.EmployeePhone.Contains(textboxName) select m;
                }
               
            }

            
            return View(display_employee);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,EmployeeName,EmployeeEmail,EmployeePhone,EmployeeDepartment")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,EmployeeName,EmployeeEmail,EmployeePhone,EmployeeDepartment")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
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
