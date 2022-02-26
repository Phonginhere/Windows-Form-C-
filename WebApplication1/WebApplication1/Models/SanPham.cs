namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        public int SanPhamId { get; set; }

        [Required]
        [StringLength(175)]
        public string SanPhamTen { get; set; }

        [StringLength(200)]
        public string SanPhamMoTa { get; set; }

        public int DanhMucsID { get; set; }

        public virtual DanhMucss DanhMucss { get; set; }
    }
}
