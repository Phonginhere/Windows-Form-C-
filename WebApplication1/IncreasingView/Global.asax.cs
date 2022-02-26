using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IncreasingView
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["countOnline"] = 0;
        }
        protected void Session_Start()
        {
            Session.Timeout = 1;
            //if (Application["countOnline"] != null)
            //{
            //    Application.Lock();
            //    int i = Convert.ToInt32(Application["countOnline"]);
            //    Application["countOnline"] = ++i;
            //    Application.UnLock();
                
            //}
            Application.Lock();
            Application["countOnline"] = (int)Application["countOnline"] + 1;
            Application.UnLock();
        }
    }
}

