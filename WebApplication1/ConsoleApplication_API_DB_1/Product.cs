namespace ConsoleApplication_API_DB_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int productId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(200)]
        public string ProductComment { get; set; }
    }
}
