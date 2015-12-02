using DeeLii.Roadio.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeeLii.Roadio.Service.ApiControllers
{
    public class POIController : ApiController
    {
        private IPOIResource _POIResource;

        public POIController()
        { }

        public POIController(IPOIResource POIResource)
        {
            _POIResource = POIResource;
        }
        // GET: api/POI
        public IEnumerable<Model.POI> Get()
        {
            return _POIResource.Get(RequestContext);
        }

        // GET: api/POI/5
        public Model.POI Get(int id)
        {
            return _POIResource.Get(id, RequestContext);
        }

        // POST: api/POI
        [HttpPost]
        public void Post(Model.POI newPOI)
        {
            _POIResource.Insert(newPOI);
        }

        // PUT: api/POI/5
        [HttpPut]
        public void Put(Model.POI modifiedPOI)
        {
            _POIResource.Update(modifiedPOI);
        }

        // DELETE: api/POI/5
        [HttpDelete]
        public void Delete(int id)
        {
            _POIResource.Delete(id);
        }
    }
}
