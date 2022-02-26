using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_SelfHost_API
{
    class Program
    {
        static void Main(string[] args)
        {
            String host = "http://localhost:1234";
            WebApp.Start<StrapupService>(url: host);
            Console.WriteLine("Created host: " + host);
            Console.ReadLine();

        }
    }
}
