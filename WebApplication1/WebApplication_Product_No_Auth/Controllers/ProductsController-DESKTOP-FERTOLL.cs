using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_Product_No_Auth.Models;

namespace WebApplication_Product_No_Auth.Controllers
{
    public class ProductsController : Controller
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Ql_Product;User ID=sa;Password=1234567";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;

        private Model_Product_Context db = new Model_Product_Context();

        // GET: Products
        public ActionResult Index_Customers()
        {
            return View(db.Product.ToList());
        }

        // GET: Products
        public ActionResult Index()
        {
            TempData["AlertMessage"] = "Create Succesfully";
            return View(db.Product.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            if (TempData.ContainsKey("Error_Img"))
            {
                String aaa = TempData["Error_Img"].ToString();
                ViewBag.Error_img = aaa;
            }

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string productName, HttpPostedFileBase productLinkImg, string productComment, double ProductPrice)
        {
            Product product = null;

            string path = Path.Combine(Server.MapPath("~/ImageStorage"), Path.GetFileName(productLinkImg.FileName));
            productLinkImg.SaveAs(path);

            int productImgSize = productLinkImg.ContentLength; //điều chỉnh size của file

            if (ModelState.IsValid) // chỉ ra rằng nếu có thể liên kết các giá trị đến từ yêu cầu từ Model một cách chính xác     
            {
                if (productImgSize > 200)
                {
                    TempData["Error_Img"] = "Capacity Image too high";
                    return RedirectToAction("Create");
                }
                else
                {
                    con = new SqlConnection(sql_con);
                    String sql = "Insert into Products values (@productName, @productLinkImg, @productComment, @ProductPrice)";
                    exec = new SqlCommand(sql, con);

                    exec.Parameters.AddWithValue("@productName", productName);
                    exec.Parameters.AddWithValue("@productLinkImg", "~/ImageStorage/" + productLinkImg.FileName);
                    exec.Parameters.AddWithValue("@productComment", productComment);
                    exec.Parameters.AddWithValue("@ProductPrice", ProductPrice);

                    con.Open();
                    exec.ExecuteNonQuery();
                    con.Close();
                    TempData["AlertMessage"] = "Create Succesfully";
                    return RedirectToAction("Index");
                }
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string productId, string productName, HttpPostedFileBase productLinkImg, string productComment, double ProductPrice)
        {
            Product product = null;
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Server.MapPath("~/ImageStorage"), Path.GetFileName(productLinkImg.FileName));
                productLinkImg.SaveAs(path);

                con = new SqlConnection(sql_con);
                String sql = "Update Products SET productName = @productName, productLinkImg = @productLinkImg,productComment = @productComment,ProductPrice = @ProductPrice where productId = @productId";
                exec = new SqlCommand(sql, con);

                exec.Parameters.AddWithValue("@productName", productName);
                exec.Parameters.AddWithValue("@productLinkImg", "~/ImageStorage/" + productLinkImg.FileName);
                exec.Parameters.AddWithValue("@productComment", productComment);
                exec.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                exec.Parameters.AddWithValue("@productId", productId);

                con.Open();
                exec.ExecuteNonQuery();
                con.Close();

                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
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
