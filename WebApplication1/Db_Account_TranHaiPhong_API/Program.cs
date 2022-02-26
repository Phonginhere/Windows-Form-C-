using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Account_TranHaiPhong_API
{
    public class Program
    {
        static void Main(string[] args)
        {
            String host = "http://localhost:6969";
            WebApp.Start<StartUpService>(url: "http://localhost:6969"); //cong host tu tao
            Console.WriteLine("Created host: " + host);
            Console.ReadLine();
        }
    }
}
