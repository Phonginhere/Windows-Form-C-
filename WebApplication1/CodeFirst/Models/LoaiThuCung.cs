using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class LoaiThuCung
    {
        public int LoaiThuCungId { get; set; }

        [Required(ErrorMessage = "Yêu cầu bạn nhập")]
        [StringLength(maximumLength: 25, ErrorMessage = "Nhập khoảng từ 4 cho đến 25", MinimumLength = 4)]
        public String LoaiThuCungName { get; set; }

        [Required(ErrorMessage = "Yêu cầu bạn nhập")]
        [StringLength(maximumLength: 50, ErrorMessage = "Nhập khoảng từ 4 cho đến 50", MinimumLength = 4)]
        public String LoaiThuCungMota { get; set; }

        public virtual ICollection<ThuCung> ThuCung { get; set; }

    }
}