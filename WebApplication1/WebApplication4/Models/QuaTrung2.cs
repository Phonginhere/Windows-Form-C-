using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class QuaTrung2
    {
        public int QuaTrung2Id { get; set; }
        public String QuaTrung2Name { get; set; }
        public String QuaTrung2Desc { get; set; }
        public int ConGa2Id { get; set; }

        public virtual ConGa2 ConGa { get; set; }
    }
}