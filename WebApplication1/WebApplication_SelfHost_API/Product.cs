namespace WebApplication_SelfHost_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string ProductCmt { get; set; }
    }
}
