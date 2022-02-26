using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store.Models
{
    public class Class
    {
        //class Id khóa chính
        public int ClassId { get; set; }

        //Class Name
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public String ClassName { get; set; }

        //tham chieu den bang con ma co khoa phu cua bang nay
        public virtual ICollection<Student> Students { get; set; }
    }
}