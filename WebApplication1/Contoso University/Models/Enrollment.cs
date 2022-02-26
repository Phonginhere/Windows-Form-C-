using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso_University.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? grade { get; set; }

        public virtual Student students { get; set; }
        public virtual Course courses { get; set; }
    }
}