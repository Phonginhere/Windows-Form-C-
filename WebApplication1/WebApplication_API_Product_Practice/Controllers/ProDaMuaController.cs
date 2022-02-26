using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_API_Product_Practice.Models;

namespace WebApplication_API_Product_Practice.Controllers
{
    public class ProDaMuaController : ApiController
    {
        Models.Model_Product db = new Models.Model_Product();
        // GET: api/ProDaMua
        public IHttpActionResult Get()
        {
            //var probuys = from p in db.ProBuys group p by p.ProId;
            int? tong_so_tien_da_ban = 0;

            //int count = probuys.Count();

            var groupedResult = db.ProBuys.GroupBy(s => s.ProId);

            foreach (var group in groupedResult)
            {
                foreach (ProBuy s in group)
                {
                    tong_so_tien_da_ban += s.ProNumber * s.ProBuyPrice;

                }  //Each group has a inner collection  


            }
            return Ok(tong_so_tien_da_ban.ToString());
            //return Ok(db.ProBuys.ToList());
        }

        // GET: api/ProSum/5
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
