using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApplication_API_DB_1
{
    public class WAController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            using (Model_Product dbContext = new Model_Product())
            {
                return dbContext.Products.ToList();
            }
            // return new string[] { "value1", "value2", "Nguyên Lê", "Nguyễn tuấn", "Nguyễn kanh", "nguyễn minh", "nguyễn quân"};

            
        }

        // GET api/values/5
        public string Get(int id)
        {
            using (Model_Product dbContext = new Model_Product())
            {
                return dbContext.Products.FirstOrDefault(e => e.productId == id).ToString();
            }
           
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
