using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store.Models
{
    //thực thể yếu
    public class Exam
    {
        //khóa chính
        public int ExamId { get; set; }

        //SubjectId khóa phụ
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public int SubjectId { get; set; }

        //StudentId khóa phụ
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public int StudentId { get; set; }

        //điểm 
        [Required(ErrorMessage = "Phải có dữ liệu")]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Điểm trong khoảng từ 0 đến 100")]
        public int Mark { get; set; }

        //tham chieu den bang cha 
        public virtual Subject Subject { get; set;}
        public virtual Student Student { get; set; }
    }
}