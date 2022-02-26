using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Db_Account_TranHaiPhong_API
{
    public class Model_Account_Context : DbContext
    {
        public Model_Account_Context() : base("name=DB_Account")
        {

        }
        public virtual DbSet<Account> Account { get; set; }
        //protected override void (DbContextOptionsBuilder optionsBuilder) 
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        //}
    }
}
