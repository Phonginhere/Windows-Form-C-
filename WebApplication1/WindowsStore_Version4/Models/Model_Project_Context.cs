using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WindowsStore_Version4.Models
{
    public class Model_Project_Context : DbContext
    {
        public Model_Project_Context() : base("name=Db_Project")
        {

        }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<AssignTask> AssignTask { get; set; }
    }
}