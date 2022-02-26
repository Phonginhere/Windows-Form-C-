using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Windows_Store.Models
{
    public class Subject
    {
        //SubjectId khóa chính
        public int SubjectId { get; set; }
        [StringLength(maximumLength: 30, ErrorMessage = "Yêu cầu nhập từ 1 đến 30", MinimumLength =1)]

        //SubjectName 
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public string SubjectName { get; set; }

        //tham chieu den bang con ma chua khoa phu cua bang nay
        public virtual ICollection<Exam> Exam { get; set; }
    }
}