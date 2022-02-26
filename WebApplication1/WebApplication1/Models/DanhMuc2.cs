using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DanhMuc2
    {
        [Key]
        public int DanhMuc2ID { get; set; }
        public String DanhMuc2Name { get; set; }
        public virtual ICollection<SanPham2> SanPham2s { get; set; }
    }
}