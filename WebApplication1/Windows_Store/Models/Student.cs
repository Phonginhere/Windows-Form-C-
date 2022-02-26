using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store.Models
{
    public class Student
    {
        //Student Id khóa chính
        public int StudentId { get; set; }

        //student name
        [Required(ErrorMessage = "Phải có dữ liệu")]
        [StringLength(maximumLength: 150, ErrorMessage = "Yêu cầu nhập từ 2 đến 150", MinimumLength = 2)]
        public String StudentName { get; set; }

        //student roll id
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public String StudentRollId { get; set; }

        //student DOB
        [Required(ErrorMessage = "Phải có dữ liệu")]
        [DataType(DataType.Date)]
        public DateTime StudentDOB { get; set; }

        //Class id khóa ngoại
        [Required(ErrorMessage = "Phải có dữ liệu")]
        public int ClassId { get; set; }

        //tham chieu den bang cha
        public virtual Class Class { get; set; }

        //tham chieu den bang con ma chua khoa phu
        public virtual ICollection<Exam> Exam { get; set; }
    }
}