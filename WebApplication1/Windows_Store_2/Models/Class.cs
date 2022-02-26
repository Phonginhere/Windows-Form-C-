using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Windows_Store_2.Models
{
    public class Class
    {
        [Required]
        public int ClassId { get; set; }

        [Required]
        //[Display(Name = "ClassName", ResourceType = typeof()]
        public String ClassName { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}