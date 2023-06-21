using System.Web;
using System.Web.Mvc;

namespace KT0720Dat_61130137
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
