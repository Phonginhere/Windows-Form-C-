using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Cay
    {
        public int CayId { get; set; }
        public String CayTen { get; set; }
        public String CayMoTa { get; set; }
        public int LoaiCayId { get; set; }

        public virtual LoaiCay LoaiCays { get; set; } // lí do là bởi vì loại cây là bảng cha
    }
}