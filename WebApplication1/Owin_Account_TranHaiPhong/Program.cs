using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Owin_Account_TranHaiPhong
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Startup>(url: "http://localhost:9095");
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> resp = client.GetAsync("http://localhost:9095/Owin/Song");
            var response = resp.Result;
            Task<String> respMessage = response.Content.ReadAsStringAsync();
            Console.WriteLine(response);
            Console.WriteLine(respMessage.Result);
            Console.ReadLine();
        }
    }
}
