using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Image.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        [Required]
        public String ImageName { get; set; }
        [Required]
        public String ImageDesc { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public String ImagePath { get; set; }
    }
}