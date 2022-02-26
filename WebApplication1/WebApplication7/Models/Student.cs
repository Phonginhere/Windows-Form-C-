using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public String StudentEmail { get; set; }
        public virtual ICollection<StudentChoose> StudentChooses { get; set; }

    }
}