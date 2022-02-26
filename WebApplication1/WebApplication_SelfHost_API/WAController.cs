using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication_SelfHost_API
{
    public class WAController : ApiController
    {
        Model1 db = new Model1();
        public IEnumerable<Product> Get()
        {

                return db.Products.ToList();
        }
        public string Get(int id)
        {
           return db.Products.FirstOrDefault(e => e.ProductId == id).ToString();
        }
        public Product Post(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return p;
        }
        public void Put(Product p)
        {
           Product pp = db.Products.Find(p.ProductId);
            pp.ProductId = p.ProductId;
            pp.ProductName = p.ProductName;
            pp.ProductCmt = p.ProductCmt;

            db.SaveChanges();
        }
    }
}
