using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Create_Profile.Models
{
    public class Employees
    {
        [Required]
        public int EmployeesId { get; set; }

        //tên của bạn
        [Required]
        [StringLength(maximumLength:25, ErrorMessage = "Nhập tên từ 2 đến 25", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public String Employee_First_Name { get; set; }

        //họ
        [Required]
        [StringLength(maximumLength: 25, ErrorMessage = "Nhập họ từ 2 đến 25", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public String Employee_Last_Name { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public byte Employee_Gender { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DataType Employee_DOB { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [RegularExpression(pattern: "(0[3|5|7|8|9])+([0-9]{8,9})\b", ErrorMessage = "Số điện thoại việt nam được định dạng như thế nào???")]
        public String Employee_Phone_Number { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([A-Za-z0-9_.]+)\@+(gmail|outlook|icloud|hotmail)*(.com|.uk|.vn|.us)$", 
            ErrorMessage = "Sai định dạng email VD: tenEmail@gmail|outlook|icloud|hotmail.com|uk|vn|us")]
        public int Employee_Email { get; set; }

        [Display(Name = "Image")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Yêu cầu nhập đúng định dạng ảnh .png|.jpg|.gif")]
        public int Employee_Image { get; set; }

        [Editable(false)]
        [Display(Name = "Date Of Birth")]
        public DateTime Employee_FirstTime_Apperance { get; set; }

    }
}