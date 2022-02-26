using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication7.Models
{
    public class Model_Student_context :DbContext
    {
        public Model_Student_context() : base("name=Model_Student")
        {

        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<SubjectMa> SubjectMas { get; set; }

        public virtual DbSet<StudentChoose> StudentChooses { get; set; }
    }
}