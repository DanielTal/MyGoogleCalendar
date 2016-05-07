﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GITSolution01.MVC5._01.EMPTY
{
    public static class WebApiConfig
    {
        //aaaa
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
