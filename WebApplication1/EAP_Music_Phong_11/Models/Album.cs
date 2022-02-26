using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Music_Phong_11.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public String Artist { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}