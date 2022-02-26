using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           // DropCreateDatabaseAlways<Model_Product_Content> khoitaoProduct = new DropCreateDatabaseAlways<Model_Product_Content>();
            //Database.SetInitializer(new DropCreateDatabaseAlways<ModelQLDanhMuc_Context>());
            //DropCreateDatabaseIfModelChanges<Model_Product_Content> khoitaoNeuNull = new DropCreateDatabaseIfModelChanges<Model_Product_Content>();
          //  Database.SetInitializer(khoitaoProduct);
        }
    }
}
