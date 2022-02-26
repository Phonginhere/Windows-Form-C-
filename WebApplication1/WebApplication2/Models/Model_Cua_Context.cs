using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class Model_Cua_Context :DbContext
    {
        public Model_Cua_Context() : base ("name=Model_ConCua")
        {
       
        }
        
        DbSet<CuaCon> CuaCons { get; set; }
        DbSet<CuaMe> CuaMes { get; set; }
    }
}