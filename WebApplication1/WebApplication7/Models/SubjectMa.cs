using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class SubjectMa
    {
        public int SubjectMaId { get; set; }
        public String SubjectMaName { get; set; }
        public virtual ICollection<StudentChoose> StudentChooses { get; set; }

    }
}