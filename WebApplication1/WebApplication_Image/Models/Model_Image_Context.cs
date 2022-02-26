using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication_Image.Models
{
    public class Model_Image_Context : DbContext
    {
        public Model_Image_Context() : base("name=Db_Image")
        {

        }
        public virtual DbSet<Image> Image { get; set; }
    }
}