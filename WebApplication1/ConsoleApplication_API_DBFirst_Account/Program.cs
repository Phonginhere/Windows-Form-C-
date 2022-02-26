using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_API_DBFirst_Account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApp.Start<StartupService>(url: "http://localhost:9095");
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> resp = client.GetAsync("http://localhost:9095/Owin/Account");
            var response = resp.Result;
            Task<String> respMessage = response.Content.ReadAsStringAsync();
            Console.WriteLine(response);
            Console.WriteLine(respMessage.Result);
            Console.ReadLine();

        }
    }
}
