using System.Web;
using System.Web.Mvc;

namespace WebApplication_Language_Religion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
