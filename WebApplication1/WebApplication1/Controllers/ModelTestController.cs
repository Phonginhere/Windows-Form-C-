using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ModelTestController : Controller
    {
        Model_Test mt = new Model_Test();
        // GET: ModelTest
        public ActionResult Index()
        {
            var lopHoc = mt.tblStudents;
            ViewBag.Model = lopHoc;
            return View();
        }

        // GET: ModelTest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ModelTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelTest/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModelTest/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModelTest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
