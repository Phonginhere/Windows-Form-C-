using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Windows_Store_2.Models
{
    public class Model_School_Context : DbContext
    {
        public Model_School_Context() : base("name=Db_School")
        {

        }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }

    }
}