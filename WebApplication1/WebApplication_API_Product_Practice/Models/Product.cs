namespace WebApplication_API_Product_Practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProBuys = new HashSet<ProBuy>();
        }

        [Key]
        public int ProId { get; set; }

        [StringLength(75)]
        public string ProName { get; set; }

        [StringLength(150)]
        public string ProContent { get; set; }

        public int? CateId { get; set; }

        public int? ProPrice { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProBuy> ProBuys { get; set; }
    }
}
