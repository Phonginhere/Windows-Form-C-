using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using quản_lý_con_cua.Models;

namespace quản_lý_con_cua.Controllers
{
    public class cuaMesController : Controller
    {
        private Model1 db = new Model1();

        // GET: cuaMes
        public ActionResult Index()
        {
            return View(db.cuaMes.ToList());
        }

        // GET: cuaMes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaMe cuaMe = db.cuaMes.Find(id);
            if (cuaMe == null)
            {
                return HttpNotFound();
            }
            return View(cuaMe);
        }

        // GET: cuaMes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cuaMes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CuaMeId,CuaMeName")] cuaMe cuaMe)
        {
            if (ModelState.IsValid)
            {
                db.cuaMes.Add(cuaMe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuaMe);
        }

        // GET: cuaMes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaMe cuaMe = db.cuaMes.Find(id);
            if (cuaMe == null)
            {
                return HttpNotFound();
            }
            return View(cuaMe);
        }

        // POST: cuaMes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CuaMeId,CuaMeName")] cuaMe cuaMe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuaMe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuaMe);
        }

        // GET: cuaMes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuaMe cuaMe = db.cuaMes.Find(id);
            if (cuaMe == null)
            {
                return HttpNotFound();
            }
            return View(cuaMe);
        }

        // POST: cuaMes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cuaMe cuaMe = db.cuaMes.Find(id);
            db.cuaMes.Remove(cuaMe);
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
