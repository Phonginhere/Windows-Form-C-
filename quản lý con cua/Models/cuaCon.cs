namespace quản_lý_con_cua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cuaCon
    {
        public int cuaConId { get; set; }

        public int cuaConSoLuong { get; set; }

        public string cuaConMoTa { get; set; }

        public int cuaMeId { get; set; }

        public virtual cuaMe cuaMe { get; set; }
    }
}
