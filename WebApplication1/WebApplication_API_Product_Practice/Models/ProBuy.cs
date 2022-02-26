namespace WebApplication_API_Product_Practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProBuy
    {
        public int ProBuyId { get; set; }

        [StringLength(75)]
        public string ProBuyDate { get; set; }

        public int ProId { get; set; }

        public int? ProBuyPrice { get; set; }

        public int? ProNumber { get; set; }

        public virtual Product Product { get; set; }
    }
}
