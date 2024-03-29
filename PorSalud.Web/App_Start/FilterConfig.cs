﻿using System.Web.Mvc;
using FluentSecurity;

namespace PorSalud.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleSecurityAttribute(), 0);
            filters.Add(new HandleErrorAttribute());
        }
    }
}