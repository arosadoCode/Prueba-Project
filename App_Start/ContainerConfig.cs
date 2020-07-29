using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Prueba_Project.Modelo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc; 
using System.Web.Services.Protocols;

namespace Prueba_Project
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<InMemoryRestaurantData>()
                    .As<IRestaurantData>()
                    .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}