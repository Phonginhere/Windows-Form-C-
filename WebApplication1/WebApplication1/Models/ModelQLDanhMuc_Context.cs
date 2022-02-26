using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace WebApplication1.Models
{
    public class ModelQLDanhMuc_Context : DbContext
    {//truyền vào chuỗi kết nối
        public ModelQLDanhMuc_Context() : base("name=Model_DanhMuc2")
        {
            
        }
        DbSet<DanhMuc2> danhmuc2 { get; set; }
        DbSet<SanPham2> sanpham2 { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.DanhMuc2> DanhMuc2 { get; set; }
    }
}