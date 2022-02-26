using EAP_Music_TranHaiPhong.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_TranHaiPhong
{
    public class DataContext : DbContext
    {

        public DataContext() : base("name=Db_Music")
        {

        }
        public virtual DbSet<Genre> Genres { get; set; } //tập thực thể loại nhạc
        public virtual DbSet<Album> Albums { get; set; } //tập thực thể loại album

    }
}