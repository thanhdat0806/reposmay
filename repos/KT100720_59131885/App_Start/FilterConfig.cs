﻿using System.Web;
using System.Web.Mvc;

namespace KT100720_59131885
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
