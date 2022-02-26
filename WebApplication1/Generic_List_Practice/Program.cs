using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Account
    {
        public string Name { get; set; } //Tên khách hàng
        public string Email { get; set; } //Thư điện tử
        public int AccNo { get; set; } //Số Tài Khoản
    }
    public class Acc_List
    {
        private List<Account> list = null;

        public Acc_List()
        {
            this.list = new List<Account>();
            list.Add(new Account() { Name = "haha", Email = "haha@gmail.com", AccNo = 12 });
        }
       
    }
}
