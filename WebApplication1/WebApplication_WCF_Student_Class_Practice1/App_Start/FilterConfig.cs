using System.Web;
using System.Web.Mvc;

namespace WebApplication_WCF_Student_Class_Practice1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
