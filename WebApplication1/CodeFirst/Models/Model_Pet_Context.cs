using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class Model_Pet_Context : DbContext
    {
        public Model_Pet_Context() : base("name=Model_Pet") {

        }
        public virtual DbSet<ThuCung> ThuCungs { get; set; }
        public virtual DbSet<LoaiThuCung> LoaiThuCung { get; set; }

       
    }
}