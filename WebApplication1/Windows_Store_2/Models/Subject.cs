using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store_2.Models
{
    public class Subject
    {
        [Required]
        public int SubjectId { get; set; }

        [Required]
        [StringLength(maximumLength:30, ErrorMessage = "Nhập từ 1 - 30 kí tự", MinimumLength = 1)]
        public String SubjectName { get; set; }

        public virtual ICollection<Exam> Exam { get; set; }
    }
}