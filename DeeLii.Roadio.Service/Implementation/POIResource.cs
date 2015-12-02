using DeeLii.Roadio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace DeeLii.Roadio.Service.Implementation
{
    public class POIResource:IPOIResource
    {
        private readonly IPOIRepository _POIRepository;

        public POIResource(IPOIRepository POIRepository, IMappingConfiguration mappingConfiguration)
        {
            _POIRepository = POIRepository;
            mappingConfiguration.Load();
        }

        public void Insert(Model.POI newPOI)
        {
            _POIRepository.Insert(newPOI);
        }

        public void Update(Model.POI modifiedPOI)
        {
            _POIRepository.Update(modifiedPOI);
        }

        public Model.POI Get(int POIId, HttpRequestContext context)
        {
            return _POIRepository.Get(POIId);
        }

        public IList<Model.POI> Get(HttpRequestContext context)
        {
            return _POIRepository.GetAll();
        }

        public void Delete(int POIId)
        {
            _POIRepository.Delete(POIId);
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_POIRepository != null)
                    {
                        _POIRepository.Dispose();
                    }
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}