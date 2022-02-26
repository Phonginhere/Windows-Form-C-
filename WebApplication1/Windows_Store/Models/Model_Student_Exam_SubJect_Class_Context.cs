using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Windows_Store.Models
{
    public class Model_Student_Exam_SubJect_Class_Context : DbContext
    {
        public Model_Student_Exam_SubJect_Class_Context() : base("name=Db_School")
        {

        }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
    }
}