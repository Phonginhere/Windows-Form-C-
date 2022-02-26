using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CuaMe
    {
        public int CuaMeID { get; set; }
        public String CuaMeName { get; set; }
        public String CuaMeMoTa { get; set; }
        //tham chiếu tới list interface của đối tượng cuaCon
        public virtual ICollection<CuaCon> CuaCons { get; set; }

    }
}