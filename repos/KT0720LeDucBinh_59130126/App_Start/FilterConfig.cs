using System.Web;
using System.Web.Mvc;

namespace KT0720LeDucBinh_59130126
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
