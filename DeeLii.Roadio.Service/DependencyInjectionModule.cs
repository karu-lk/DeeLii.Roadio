using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeeLii.Roadio.Service.Implementation;
using DeeLii.Roadio.Repository;

namespace DeeLii.Roadio.Service
{
    public class DependencyInjectionModule:NinjectModule
    {
        public override void Load()
        {
            Bind<RoadioDatabaseEntities>().To<RoadioDatabaseEntities>();
            Bind<IMappingConfiguration>().To<MappingConfiguration>();
            Bind<IPOIRepository>().To<POIRepository>();
            Bind<IPOIResource>().To<POIResource>();
        }
    }
}