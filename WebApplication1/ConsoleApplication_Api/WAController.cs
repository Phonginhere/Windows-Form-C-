using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication_Api

{
    public class WAController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "Gia trị 2 ", "Hải Anh", "Minh Anh ", "Lê Minh", "Quang Minh ", "Nhật Minh" };
        }

        
    }
    public class ProductController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Asus", "value2", "Gia trị 2 ", "Hải Anh", "Minh Anh ", "Lê Minh", "Quang Minh ", "Nhật Minh" };
        }
    }

    public class ProductDbController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            // return new string[] { "value1", "value2", "Nguyên Lê", "Nguyễn tuấn", "Nguyễn kanh", "nguyễn minh", "nguyễn quân"};
            return Product.GetListProduct();
        }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public String Price { get; set; }
        public String Quantity { get; set; }
        public DateTime ReleaseDate { get; set; }

        public static List<Product> GetListProduct()
        {
            List<Product> pl1 = new List<Product>();
            string connectionString = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=ProductManagement;User ID=sa;Password=1234567";

            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Product", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count > 0)

            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    Product pl = new Product();

                    pl.ProductId = Convert.ToInt32(dt.Rows[i]["ProductId"].ToString());

                    pl.Name = dt.Rows[i]["Name"].ToString();

                    pl.Price = (dt.Rows[i]["Price"].ToString());

                    pl.Quantity = (dt.Rows[i]["Quantity"].ToString());

                    pl.ReleaseDate = Convert.ToDateTime(dt.Rows[i]["ReleaseDate"].ToString());

                    pl1.Add(pl);

                }

            }
            return pl1;
        }
    }
}
