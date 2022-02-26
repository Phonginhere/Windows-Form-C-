using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Music_TranHaiPhong.Models
{
    public class Genre
    {
        public int GenreId { get; set; } //id thể loại

        [Required]
        public string GenreName { get; set; } //tên thể loại

        [Required]
        public virtual ICollection<Album> Albums { get; set; }


        public Genre()
        {
             this.Albums = new HashSet<Album>();
        }

    }
}