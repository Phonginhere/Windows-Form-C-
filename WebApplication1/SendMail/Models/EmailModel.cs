using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SendMail.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = "yêu cầu nhập")]
        [RegularExpression(@"^([A-Za-z0-9_.]+)\@+(gmail|yahoo)*(.com|.vn)$", ErrorMessage = "Sai định dạng email VD: tenemail@gmail|yahoo.com|.vn")]
        public string From { get; set; } //from tu ai do

        [Required(ErrorMessage = "yêu cầu nhập")]
        [StringLength(maximumLength: 32, ErrorMessage = "Yêu cầu nhập từ 6 đến 32 kí tự trở lên", MinimumLength = 6)]
        public string Password { get; set; } // password
        [Required(ErrorMessage = "yêu cầu nhập")]
        [RegularExpression(@"^([A-Za-z0-9_.]+)\@+(gmail|yahoo)*(.com|.vn)$", ErrorMessage = "Sai định dạng email VD: tenemail@gmail|yahoo.com|.vn")]
        public String To { get; set; } //gui cho ai do mail

        public String Subject { get; set; } //tieu de

        [Required(ErrorMessage = "yêu cầu nhập")]
        public String Body { get; set; } //noi dung
    }
}