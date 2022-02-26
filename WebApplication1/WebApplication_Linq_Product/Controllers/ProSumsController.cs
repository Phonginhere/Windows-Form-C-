using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_Linq_Product.Models;

namespace WebApplication_API_Product_Practice.Controllers
{
    public class ProSumsController : ApiController
    {
        Model_Product db = new Model_Product();
        // GET: api/ProSums
        public IHttpActionResult Get()
        {
            return Ok(db.ProBuys.ToList());
        }

        // GET: api/ProSums/5
        public string Get(int id)
        {
            var product_count = db.ProBuys.Where(p => p.ProId == id).Select(p => p.ProNumber);
            var product_money_total = db.ProBuys.Where(p => p.ProId == id).Select(p => p.ProBuyPrice);
            int? total_count_product = 0;
            int? total_count_money = 0;
            int count = product_count.Count();
            int count2 = product_money_total.Count();
            foreach(var i in product_count)
            {
                total_count_product += i;
            }
            foreach (var ii in product_money_total)
            {
                total_count_money += ii;
            }
            return "Tổng số tiền đã mua cho sản phẩm: "+(total_count_product * total_count_money);
        }

        // POST: api/ProSums
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProSums/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProSums/5
        public void Delete(int id)
        {
        }
    }
}
