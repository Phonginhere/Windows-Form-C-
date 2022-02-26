namespace ConsoleApplication_API_DBFirst_Account
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Acc : DbContext
    {
        public Model_Acc()
            : base("name=Model_Acc")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccEmail)
                .IsUnicode(false);
        }
    }
}
