using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace DeeLii.Roadio.Service.Implementation
{
    public interface IPOIResource:IDisposable
    {
        IList<Model.POI> Get(HttpRequestContext requestContext);
        Model.POI Get(int POIID, HttpRequestContext requestContext);
        void Update(Model.POI modifiedPOI);
        void Insert(Model.POI newPOI);
        void Delete(int POIID);
    }
}
