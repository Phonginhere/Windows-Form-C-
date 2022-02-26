using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models
{
    public class DanhMucss
    {
        [Key]
        public int DanhMucId { get; set; }
        public String DanhMucName { get; set; }
        
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}