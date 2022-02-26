using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        public String StudentName { get; set; }
        public String Student_Email { get; set; }
        public String Student_pass { get; set; }
        public ICollection<Score> scores {get; set;}
    }
}