using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class LoaiCay
    {
        public int LoaiCayId { get; set; }
        public String LoaiCayTen { get; set; }
        public String LoaiCayMoTa { get; set; }

        public virtual ICollection<Cay> Cays { get; set; } //đây là bảng con
    }
}