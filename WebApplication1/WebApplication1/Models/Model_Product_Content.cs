using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Model_Product_Content :DbContext
    {
        public Model_Product_Content() : base("name=Model_Product")
        {

        }
        public DbSet<DanhMuc2> DanhMucs { get; set; }
        public DbSet<SanPham2> SanPhams { get; set; }
    }
}