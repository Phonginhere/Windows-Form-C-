using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ShowTable_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=ProductManagement;User ID=sa;Password=1234567";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * from Product", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.Write("ID: "+dr[0].ToString());
                            Console.Write("Name: "+dr[1].ToString());
                            Console.Write("Price: "+dr[2].ToString());
                            Console.Write("Quantity: "+dr[3].ToString());
                            Console.Write("Release Date: "+dr[4].ToString());
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
