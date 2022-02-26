using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public Customer()
        {
            CustomerID = 1;
            CustomerName = "Phong";
            CustomerAddress = "Cầu Giấy, Hà Nội";
        }
    }
}