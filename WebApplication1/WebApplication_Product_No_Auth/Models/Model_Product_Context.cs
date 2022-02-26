using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication_Product_No_Auth.Models
{
    public class Model_Product_Context : DbContext
    {
        public Model_Product_Context() : base("name=DbProduct")
        {

        }
        public virtual DbSet<Product> Product { get; set; }

    }
}