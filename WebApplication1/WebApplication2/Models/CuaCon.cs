using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CuaCon
    {
        public int CuaConID { get; set; }
        public int CuaConSoLuong { get; set; }
        public String CuaConMoTa { get; set; }
        //khóa ngoại của CuaMeID
        public int CuaMeID { get; set; }
        // tham chiếu tới Cua Me vì tạo đối tượng ảo
        public virtual CuaMe CuaMe { get; set; }
    }
}