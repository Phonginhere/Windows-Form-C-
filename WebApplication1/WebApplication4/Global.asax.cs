using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           // DropCreateDatabaseAlways<Model_GaTrung_Context> mgc = new DropCreateDatabaseAlways<Model_GaTrung_Context>();
            // Database.SetInitializer(mgc);

            DropCreateDatabaseIfModelChanges<Model_GaTrung_Context> mcc = new DropCreateDatabaseIfModelChanges<Model_GaTrung_Context>();
            Database.SetInitializer(mcc);

           

        }
    }
}
