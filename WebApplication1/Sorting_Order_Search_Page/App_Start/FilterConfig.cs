using System.Web;
using System.Web.Mvc;

namespace Sorting_Order_Search_Page
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
