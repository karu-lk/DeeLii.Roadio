using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeeLii.Roadio.Service
{
    public class MappingConfiguration : IMappingConfiguration
    {
        public void Load()
        {
            Mapper.CreateMap<Repository.POI, Model.POI>();
            Mapper.CreateMap<Model.POI, Repository.POI>();
        }
    }
}