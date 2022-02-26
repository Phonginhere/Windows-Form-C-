using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Db_Account_TranHaiPhong_API
{
    public class StartUpService
    {
        public void Configuration(IAppBuilder appbuilder) //Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Product_DB;User ID=sa
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "Owin", 
                routeTemplate: "Owin/{Controller}/{id}", 
                defaults: new { id = RouteParameter.Optional }); // RouteParameter.Optional có thể có hoặc không
            appbuilder.UseWebApi(config);
        }

    }
}
