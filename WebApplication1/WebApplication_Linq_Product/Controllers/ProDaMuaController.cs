using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_Linq_Product.Models;

namespace WebApplication_Linq_Product.Controllers
{
    public class ProDaMuaController : ApiController
    {
        Models.Model_Product db = new Models.Model_Product();
        // GET: api/ProDaMua
        public IHttpActionResult Get()
        {
            int? tong_so_tien_mathang = 0;
            var total_count_product = db.ProBuys.GroupBy(p => p.ProId);
            
            foreach (var ii in total_count_product)
            {
                foreach (ProBuy pb in ii)
                {
                    tong_so_tien_mathang += pb.ProBuyPrice * pb.ProNumber;
                }
            }

            return Ok("tổng số tiền cho tấ cả mặt hàng là: "+tong_so_tien_mathang);
        }

        // GET: api/ProDaMua/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProDaMua
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProDaMua/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProDaMua/5
        public void Delete(int id)
        {
        }
    }
}
