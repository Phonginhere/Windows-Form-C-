using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadImgAnhDocx.Models
{
    public class Model_ImgDocx
    {
        //image 
        [DataType(DataType.Upload)]
        [Display(Name = "Upload File Image")]
        [Required(ErrorMessage = "Please choose image to upload.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "yêu cầu đúng định dạng .png|.jpg|.gif")]
        public String ImgUpload { get; set; }

        //docx
        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "Please choose file to upload.")]
        [Display(Name = "Upload File Docx")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.txt|.doc|.docx|.pdf)$", ErrorMessage = "yêu cầu đúng định dạng .txt|.docx|.pdf|.doc")]
        //[RegularExpression(@"[a-zA-Z0-9\s_\\.\-:])+(.txt|.doc|.docx|.pdf)$", ErrorMessage = "yêu cầu đúng định dạng .txt|.docx|.pdf")]
        public String DocxUpload { get; set; }

        //[DataType(DataType.Upload)]
        //[Display(Name = "Upload File")]
        //[Required(ErrorMessage = "Please choose file to upload.")]
        //public string file { get; set; }
    }
}