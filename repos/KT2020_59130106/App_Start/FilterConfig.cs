﻿using System.Web;
using System.Web.Mvc;

namespace KT2020_59130106
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
