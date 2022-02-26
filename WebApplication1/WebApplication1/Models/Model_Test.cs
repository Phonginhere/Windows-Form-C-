namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Test : DbContext
    {
        public Model_Test()
            : base("name=Model_Test")
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
    }
}
