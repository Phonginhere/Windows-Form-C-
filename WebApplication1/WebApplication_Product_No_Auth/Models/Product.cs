using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Product_No_Auth.Models
{
    public class Product
    {
        public int productId { get; set; }

        [Required(ErrorMessage ="Pls Input")]
        [StringLength(maximumLength: 100, ErrorMessage = "Input from 2 to 100 characters" , MinimumLength = 2)]
        [Display(Name = "Input Product Name")]
        public String productName { get; set; }

        [Required(ErrorMessage = "Pls Input")]
        [StringLength(maximumLength: 250, ErrorMessage = "Input from 2 to 250 characters", MinimumLength = 2)]
        [Display(Name = "Input Product Link Image")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Yêu cầu nhập đúng định dạng ảnh .png|.jpg|.gif")]
        public String productLinkImg { get; set; }

        [Required(ErrorMessage = "Pls Input")]
        [StringLength(maximumLength: 100, ErrorMessage = "Input from 2 to 100 characters", MinimumLength = 2)]
        [Display(Name = "Input Product Comment")]
        public String productComment { get; set; }

        [Required(ErrorMessage = "Pls Input")]
        [Range(minimum: 1000 , maximum: 1000000000,  ErrorMessage = "Nhập từ 1000 đến 1 tỷ")]
        [Display(Name = "Input Product Price")]
        public double ProductPrice { get; set; }

    }
}