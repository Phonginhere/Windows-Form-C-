using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public class Model_GaTrung_Context : DbContext
    {
        public Model_GaTrung_Context() : base("name=GaTrung")
        {

        }
        public virtual DbSet<ConGa2> ConGa { get; set; }
        public virtual DbSet<QuaTrung2> QuaTrung { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}