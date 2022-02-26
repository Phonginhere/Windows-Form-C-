using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadDb_NameImage.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "Please choose file to upload.")]
        [Display(Name = "Upload File Path")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Yêu cầu nhập đúng định dạng ảnh .png|.jpg|.gif")]
        [StringLength(maximumLength: 250, ErrorMessage ="độ dài từ 2 đến 250", MinimumLength = 2)]
        public String ImagePath { get; set; }

    }
}