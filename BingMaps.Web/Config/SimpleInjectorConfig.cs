using AutoMapper;
using BingMaps.Core.Domain;
using BingMaps.Core.EF;
using BingMaps.Core.Repositories;
using BingMaps.Core.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BingMaps.Web.Config
{
    public class SimpleInjectorConfig
    {
        public static Container Config()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<IPointService, BingMapsService>(Lifestyle.Scoped);


            container.Register<BingMapContext>(Lifestyle.Singleton);
            container.Register<IRepository<Point>, Repository<Point>>();

            var mapper = MappingProfile.InitializeAutoMapper().CreateMapper();
            container.RegisterInstance<IMapper>(mapper);

            container.Verify();
            return container;
        }
    }
}