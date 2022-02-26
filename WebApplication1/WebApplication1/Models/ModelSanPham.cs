namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelSanPham : DbContext
    {
        public ModelSanPham()
            : base("name=ModelSanPham")
        {
        }

        public virtual DbSet<DanhMucss> DanhMucsses { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucss>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.DanhMucss)
                .WillCascadeOnDelete(false);
        }
    }
}
