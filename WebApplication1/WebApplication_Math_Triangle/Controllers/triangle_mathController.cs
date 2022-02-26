using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_Math_Triangle.Models;

namespace WebApplication_Math_Triangle.Controllers
{
    public class triangle_mathController : Controller
    {
        private QL_TamGiacEntities db = new QL_TamGiacEntities();

        // GET: triangle_math
        public ActionResult Index()
        {
            return View(db.triangle_math.ToList());
        }

        // GET: triangle_math/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            triangle_math triangle_math = db.triangle_math.Find(id);
            if (triangle_math == null)
            {
                return HttpNotFound();
            }
            return View(triangle_math);
        }

        // GET: triangle_math/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: triangle_math/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,tri_edge1,tri_edge2,tri_edge3")] triangle_math triangle_math)
        {
            if (ModelState.IsValid)
            {
                db.triangle_math.Add(triangle_math);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(triangle_math);
        }

        // GET: triangle_math/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            triangle_math triangle_math = db.triangle_math.Find(id);
            if (triangle_math == null)
            {
                return HttpNotFound();
            }
            return View(triangle_math);
        }

        // POST: triangle_math/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,tri_edge1,tri_edge2,tri_edge3")] triangle_math triangle_math)
        {
            if (ModelState.IsValid)
            {
                db.Entry(triangle_math).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(triangle_math);
        }

        // GET: triangle_math/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            triangle_math triangle_math = db.triangle_math.Find(id);
            if (triangle_math == null)
            {
                return HttpNotFound();
            }
            return View(triangle_math);
        }

        // POST: triangle_math/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            triangle_math triangle_math = db.triangle_math.Find(id);
            db.triangle_math.Remove(triangle_math);
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
