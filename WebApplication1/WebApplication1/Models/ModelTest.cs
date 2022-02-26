namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelTest : DbContext
    {
        public ModelTest()
            : base("name=ModelTest")
        {
        }

        public virtual DbSet<tblClass> tblClasses { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblStudent>()
                .Property(e => e.UserNm)
                .IsUnicode(false);

            modelBuilder.Entity<tblStudent>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.DanhMucss> DanhMucsses { get; set; }
    }
}
