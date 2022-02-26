namespace WebApplication_API_Product_Practice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Product : DbContext
    {
        public Model_Product()
            : base("name=Model_Product")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProBuy> ProBuys { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProBuys)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
