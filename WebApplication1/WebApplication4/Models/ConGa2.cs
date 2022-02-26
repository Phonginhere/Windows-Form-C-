using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class ConGa2
    {
        public int ConGa2Id { get; set; }
        public String ConGa2Name { get; set; }
        public String ConGa2Des { get; set; }

        public virtual ICollection<QuaTrung2> QuaTrung { get; set; }
    }
}