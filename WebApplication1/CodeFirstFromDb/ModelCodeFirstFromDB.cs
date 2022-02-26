namespace CodeFirstFromDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCodeFirstFromDB : DbContext
    {
        public ModelCodeFirstFromDB()
            : base("name=ModelCodeFirstFromDB")
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
