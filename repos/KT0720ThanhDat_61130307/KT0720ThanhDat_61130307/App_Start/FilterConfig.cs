using System.Web;
using System.Web.Mvc;

namespace KT0720ThanhDat_61130307
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
