using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_Linq_Product.Controllers
{
    public class ProCounterController : ApiController
    {
        Models.Model_Product db = new Models.Model_Product();
        // GET: api/ProCounter
        public IHttpActionResult Get()
        {
            return Ok(db.ProBuys);
        }

        // GET: api/ProCounter/5
        public string Get(int id)
        {
            var probuys = db.ProBuys.Where(p => p.ProId == id).Select(p => p.ProNumber);
            return "tổng số mặt hàng trong ngày hôm đó là: "+ probuys.First();
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
