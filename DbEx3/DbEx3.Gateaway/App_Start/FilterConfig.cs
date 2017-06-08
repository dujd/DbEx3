using System.Web;
using System.Web.Mvc;

namespace DbEx3.Gateaway
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
