using System.Web;
using System.Web.Mvc;

namespace WebApplication_Math_Triangle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
