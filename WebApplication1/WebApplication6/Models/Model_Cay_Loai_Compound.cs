using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class Model_Cay_Loai_Compound : DbContext
    {
        public Model_Cay_Loai_Compound(): base("name=Tree")
        {

        }
        public virtual DbSet<LoaiCay> LoaiCay { get; set; }
        public virtual DbSet<Cay> Cay { get; set; }
    }
}