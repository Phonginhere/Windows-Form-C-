using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class StudentChoose
    {
        public int StudentChooseId { get; set; }
        public int StudentId { get; set; }
        public int SubjectMaId { get; set; }
        public int Diem { get; set; }

        public virtual Student Student { get; set; }
        public virtual SubjectMa SubjectMa { get; set; }
    }
}