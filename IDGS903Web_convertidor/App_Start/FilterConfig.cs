using System.Web;
using System.Web.Mvc;

namespace IDGS903Web_convertidor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
