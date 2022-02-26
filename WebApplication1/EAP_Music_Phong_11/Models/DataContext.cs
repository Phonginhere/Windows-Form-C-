using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_Phong_11.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=Model_Music")
        {

        }
       public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
    }
}