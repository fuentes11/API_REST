﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Changing output to Json instead XML
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

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
