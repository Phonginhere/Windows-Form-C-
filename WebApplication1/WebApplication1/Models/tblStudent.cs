namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStudent")]
    public partial class tblStudent
    {
        [Key]
        public int MaSv { get; set; }

        [StringLength(30)]
        public string TenSV { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NSinh { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        public int? MaLop { get; set; }

        [StringLength(20)]
        public string UserNm { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public virtual tblClass tblClass { get; set; }
    }
}
