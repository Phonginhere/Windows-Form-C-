using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store_2.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Nhập từ 1 - 30 kí tự", MinimumLength = 2)]
        public String StudentName { get; set; }

        [Required]
        public String StudentRollId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public String StudentDOB { get; set; }

        [Required]
        public int ClassId { get; set; }

        public virtual ICollection<Exam> Exam { get; set; }
        
        public virtual Class Class { get; set; }
    }
}