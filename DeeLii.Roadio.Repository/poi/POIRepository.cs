using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeeLii.Roadio;
using AutoMapper;

namespace DeeLii.Roadio.Repository
{
    public class POIRepository:IPOIRepository
    {
        private readonly RoadioDatabaseEntities _dbContext;

        public POIRepository(RoadioDatabaseEntities context)
        {
            _dbContext = context;
        }

        public Model.POI Get(int POIId)
        {
            var daoPOI = _dbContext.POIs.SingleOrDefault(b => b.POIId == POIId);
            var POI = Mapper.Map<Model.POI>(daoPOI);
            return POI;
        }

        public IList<Model.POI> GetAll()
        {
            var daoPOI = _dbContext.POIs.ToList();
            return Mapper.Map<IList<Model.POI>>(daoPOI);
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_dbContext != null)
                    {
                        _dbContext.Dispose();
                    }
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Update(Model.POI modifiedPOI)
        {
            POI daoPOI = Mapper.Map<POI>(modifiedPOI);
            _dbContext.POIs.Attach(daoPOI);
            var entry = _dbContext.Entry(daoPOI);
            entry.State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Insert(Model.POI newPOI)
        {
            POI daoPOI = Mapper.Map<POI>(newPOI);
            _dbContext.POIs.Add(daoPOI);
            _dbContext.SaveChanges();
        }

        public void Delete(int POIId)
        {
            var daoPOI = new POI { POIId = POIId};
            _dbContext.POIs.Attach(daoPOI);
            _dbContext.POIs.Remove(daoPOI);
            _dbContext.SaveChanges();
        }
    }
}
