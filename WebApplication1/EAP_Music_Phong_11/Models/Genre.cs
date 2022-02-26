using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Music_Phong_11.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Albums = new HashSet<Album>();
        }
        [Key]
        public int GenreId { get; set; }

        [Required]
        public String GenreName { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}