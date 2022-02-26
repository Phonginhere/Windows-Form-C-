using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class ThuCung
    {
        public int ThuCungId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        [StringLength(maximumLength: 25, ErrorMessage = "nhập từ 4 đến 25", MinimumLength = 4)]
        public String ThuCungTen { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        [StringLength(maximumLength: 50, ErrorMessage = "nhập từ 4 đến 50", MinimumLength = 4)]
        public String ThuCungMoTa { get; set; }

        public virtual LoaiThuCung LoaiThuCung { get; set; }
    }
}