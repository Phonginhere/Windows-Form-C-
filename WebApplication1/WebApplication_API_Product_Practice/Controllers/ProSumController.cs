using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_API_Product_Practice.Models;

namespace WebApplication_API_Product_Practice.Controllers
{
    public class ProSumController : ApiController
    {
        Models.Model_Product db = new Model_Product();
        // GET: api/ProSum
        public IHttpActionResult Get()
        {
            return Ok(db.ProBuys.ToList());
        }

        // GET: api/ProSum/5
        public int? Get(int id)
        {
            var probuys = from p in db.ProBuys where p.ProId == id select p; //lấy sản phẩm cần truyền vào VD: lấy id = 1 thì id đó có bao nhiêu xe đạp đã được bán
            int? tong_so_tien_da_ban = 0;
            
            int count = probuys.Count();
            foreach (var p in probuys)
            {
                tong_so_tien_da_ban += p.ProBuyPrice * p.ProNumber; //đếm tổng số sản phẩm bán được là bao nhiêu

            }
            
            return tong_so_tien_da_ban;

        }

        // POST: api/ProSum
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProSum/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProSum/5
        public void Delete(int id)
        {
        }
    }
}
