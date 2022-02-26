using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class Model_DM_SP :DbContext
    {
        public Model_DM_SP() : base("name=ModelDanhMuc")
        {

        }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<DanhMucss> DanhMuc { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
            .HasOptional<DanhMucss>(s => s.DanhMuc)
            .WithMany()
            .WillCascadeOnDelete(true);
        }
    }
}