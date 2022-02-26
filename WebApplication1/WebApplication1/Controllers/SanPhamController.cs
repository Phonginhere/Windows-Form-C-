using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SanPhamController : Controller
    {
        //SqlConnection con;
        //SqlCommand exec;
        //SqlDataAdapter read;
        //String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=QLSanPham;User ID=sa;Password=1234567;";

        ModelSanPham msp = new ModelSanPham();
        // GET: SanPham
        public ActionResult Index()
        {
            var iii = msp.DanhMucsses;
            ViewData.Model = iii;
            return View();
        }
        public ActionResult Index2()
        {
            var iii = msp.SanPhams;
            ViewData.Model = iii;
            return View();
        }

        // GET: SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {

            try
            {
                // TODO: Add insert logic here
                int a = 0;
                a++;
                
                msp.SanPhams.Add(sp);
                msp.SaveChanges();
                return RedirectToAction("Index2");
            }
            catch
            {
                ModelState.AddModelError(nameof(SanPham.DanhMucsID), "Không có thông tin ở danh mục đó, vui lòng thử lại!");
                return View();
            }
        }

        // GET: DanhMuc/Create
        public ActionResult CreateDanhMuc()
        {
            return View();
        }
        //Post DanhMuc/Create
        [HttpPost]
        public ActionResult CreateDanhMuc(DanhMucss dm)
        {
            try
            {
                int a = 0;
                a++;
                msp.DanhMucsses.Add(dm);
                msp.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SanPham sp)
        {
            try
            {
                // TODO: Add update logic here
                int a = 0;
                a++;
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPham/Delete/5
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
