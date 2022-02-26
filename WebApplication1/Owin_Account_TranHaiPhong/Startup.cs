using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Owin_Account_TranHaiPhong
{
    public class Startup
    {
        public void Configuration(IAppBuilder appbuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "Owin", routeTemplate: "Owin/{Controller}/{id}", defaults: new { id = RouteParameter.Optional });
            appbuilder.UseWebApi(config);
        }
    }
}
