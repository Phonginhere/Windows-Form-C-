using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_Language_Religion.Models;

namespace WebApplication_Language_Religion.Controllers
{
    public class Religion_LanguageController : Controller
    {
        private QL_Language_ReligionEntities db = new QL_Language_ReligionEntities();

        // GET: Religion_Language
        public ActionResult Index()
        {
            return View(db.Religion_Language.ToList());
        }

        // GET: Religion_Language/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion_Language religion_Language = db.Religion_Language.Find(id);
            if (religion_Language == null)
            {
                return HttpNotFound();
            }
            return View(religion_Language);
        }

        // GET: Religion_Language/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Religion_Language/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name")] Religion_Language religion_Language)
        {
            if (ModelState.IsValid)
            {
                db.Religion_Language.Add(religion_Language);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(religion_Language);
        }

        // GET: Religion_Language/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion_Language religion_Language = db.Religion_Language.Find(id);
            if (religion_Language == null)
            {
                return HttpNotFound();
            }
            return View(religion_Language);
        }

        // POST: Religion_Language/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name")] Religion_Language religion_Language)
        {
            if (ModelState.IsValid)
            {
                db.Entry(religion_Language).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(religion_Language);
        }

        // GET: Religion_Language/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion_Language religion_Language = db.Religion_Language.Find(id);
            if (religion_Language == null)
            {
                return HttpNotFound();
            }
            return View(religion_Language);
        }

        // POST: Religion_Language/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Religion_Language religion_Language = db.Religion_Language.Find(id);
            db.Religion_Language.Remove(religion_Language);
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
