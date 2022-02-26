using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store_2.Models
{
    public class Exam
    {

        [Required]
        public int ExamId { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        [Range(minimum: 0, maximum: 100, ErrorMessage ="Nhập điểm từ 0 đến 100")]
        public int Mark { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}