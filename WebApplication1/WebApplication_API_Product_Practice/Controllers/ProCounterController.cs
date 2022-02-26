using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_API_Product_Practice.Models;

namespace WebApplication_API_Product_Practice.Controllers
{
    public class ProCounterController : ApiController
    {
        Models.Model_Product db = new Model_Product();
        // GET: api/ProCounter
        public IHttpActionResult Get()
        {
            return Ok(db.ProBuys.ToList());
        }


        // GET: api/ProCounter/5
        //public int? Get(int id)
        //{
        //    var total_product = from p in db.ProBuys where p.ProBuyId == id select p.ProNumber;
        //    return total_product.Single();

        //}

        // GET: api/ProCounter/5
        public int? Get(int id)
        {
            var probuys = from p in db.ProBuys where p.ProId == id select p; //lấy sản phẩm cần truyền vào VD: lấy id = 1 thì id đó có bao nhiêu xe đạp đã được bán
            int? tong_so_sanpham_daban = 0;
            int count = probuys.Count();
            foreach(var p in probuys)
            {
                tong_so_sanpham_daban += p.ProNumber; //đếm tổng số sản phẩm bán được là bao nhiêu
            }
            return tong_so_sanpham_daban;

        }




        // POST: api/ProCounter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProCounter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProCounter/5
        public void Delete(int id)
        {
        }
    }
}
