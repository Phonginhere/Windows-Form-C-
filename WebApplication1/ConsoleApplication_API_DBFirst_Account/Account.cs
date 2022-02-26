namespace ConsoleApplication_API_DBFirst_Account
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int AccId { get; set; }

        [StringLength(50)]
        public string AccName { get; set; }

        [StringLength(30)]
        public string AccEmail { get; set; }

        public int? AccNo { get; set; }
    }
}
