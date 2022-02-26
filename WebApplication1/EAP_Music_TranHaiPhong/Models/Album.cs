using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Music_TranHaiPhong.Models
{
    public class Album
    {
        public int AlbumId { get; set; } //Id album nhạc

        [Required]
        [StringLength(maximumLength: 32, ErrorMessage = "Tựa đề Album chỉ được phép có từ 3 đến 32 kí tự.", MinimumLength = 3)]
        public string Title { get; set; } //Tựa đề album

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } //ngày phát hành

        [Required]
        public string Artist { get; set; } // Ca sĩ, nhóm nhạc

        [Required]
        [Range(minimum: 1, maximum:15, ErrorMessage = "Giá phải nằm trong khoảng từ 1 đến 15 $")]
        public double Price { get; set; } //giá (đô)

        public int GenreId { get; set; } //id thể loại

        public virtual Genre Genre { get; set; } //thể loại (tham chiếu sang bảng ...)
    }
}