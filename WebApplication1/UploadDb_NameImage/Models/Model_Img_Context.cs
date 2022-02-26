using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UploadDb_NameImage.Models
{
    public class Model_Img_Context : DbContext
    {
        public Model_Img_Context() : base("name=Db_Image")
        {

        }
        public virtual DbSet<Image> Image { get; set; }
    }
}