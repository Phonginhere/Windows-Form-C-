using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace ConsoleApplication_Api
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Startup_Service>(url: "http://localhost:9095");
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> resp = client.GetAsync("http://localhost:9095/Owin/ProductDb");
            var response = resp.Result;
            Task<String> respMessage = response.Content.ReadAsStringAsync();
            Console.WriteLine(response);
            Console.WriteLine(respMessage.Result);
            Console.ReadLine();
        }
    }
}
