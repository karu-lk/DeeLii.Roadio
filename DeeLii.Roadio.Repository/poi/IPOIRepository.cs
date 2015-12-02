using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeeLii.Roadio.Repository
{
    public interface IPOIRepository : IDisposable
    {
        IList<Model.POI> GetAll();
        Model.POI Get(int POIId);
        void Update(Model.POI modifiedPOI);
        void Insert(Model.POI newPOI);
        void Delete(int POIId);
    }
}
