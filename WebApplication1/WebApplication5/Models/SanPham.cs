using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class SanPham
    {
        [Key]
        public int SanPhamId { get; set; }
        public String SanPhamTen { get; set; }
        public String SanPhamMoTa { get; set; }
        public int DanhMucId { get; set; }

        public virtual DanhMucss DanhMuc { get; set; }
    }
}