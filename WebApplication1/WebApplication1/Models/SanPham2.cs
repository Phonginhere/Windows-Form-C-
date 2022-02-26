using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SanPham2
    {
        [Key]
        public int SanPhamID { get; set; }
        public int SanPhamTen { get; set; }
        public int SanPhamMoTa { get; set; }
        public int DanhMuc2ID { get; set; }
        
        public virtual DanhMuc2 DanhMuc2 { get; set; }
    }
}