using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Hosting;

namespace ConsoleApplication_Api
{
    public class Startup_Service
    {
        public void Configuration(IAppBuilder appbuilder)
        {
            //System.Web.Http
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "Owin",
                routeTemplate: "Owin/{Controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            appbuilder.UseWebApi(config);
        }
    }
}
