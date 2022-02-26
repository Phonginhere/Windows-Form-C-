using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication6.Models;
namespace WebApplication6
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DropCreateDatabaseIfModelChanges<Model_Cay_Loai_Compound> mclc = new DropCreateDatabaseIfModelChanges<Model_Cay_Loai_Compound>();
            Database.SetInitializer(mclc);
        }
    }
}
