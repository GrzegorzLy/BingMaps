using BingMaps.Core.EF;
using BingMaps.Core.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BingMaps.Web.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void RegisterComponents()
        {
            var container = new Container();

            container.Register<BingMapContext>(Lifestyle.Singleton);
            container.Register(typeof(IRepository<>), typeof(IRepository<>).Assembly);


            container.RegisterMvcControllers(
          System.Reflection.Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}