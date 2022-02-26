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
    public class ConGa2Controller : Controller
    {
        private Model_GaTrung_Context db = new Model_GaTrung_Context();

        // GET: ConGa2
        public ActionResult Index()
        {
            return View(db.ConGa.ToList());
        }

        // GET: ConGa2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConGa2 conGa2 = db.ConGa.Find(id);
            if (conGa2 == null)
            {
                return HttpNotFound();
            }
            return View(conGa2);
        }

        // GET: ConGa2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConGa2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConGa2Id,ConGa2Name,ConGa2Des")] ConGa2 conGa2)
        {
            if (ModelState.IsValid)
            {
                db.ConGa.Add(conGa2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conGa2);
        }

        // GET: ConGa2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConGa2 conGa2 = db.ConGa.Find(id);
            if (conGa2 == null)
            {
                return HttpNotFound();
            }
            return View(conGa2);
        }

        // POST: ConGa2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConGa2Id,ConGa2Name,ConGa2Des")] ConGa2 conGa2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conGa2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conGa2);
        }

        // GET: ConGa2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConGa2 conGa2 = db.ConGa.Find(id);
            if (conGa2 == null)
            {
                return HttpNotFound();
            }
            return View(conGa2);
        }

        // POST: ConGa2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConGa2 conGa2 = db.ConGa.Find(id);
            db.ConGa.Remove(conGa2);
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
