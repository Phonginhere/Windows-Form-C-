namespace WebApplication_DbFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        public int MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        public int RunningTime { get; set; }

        public int GenreId { get; set; }

        [Column(TypeName = "money")]
        public decimal BoxOffice { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
