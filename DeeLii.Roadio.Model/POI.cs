using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeeLii.Roadio.Model
{
    public class POI
    {
        public int POIId { get; set; }
        public int POICategoryId { get; set; }
        public string POIName { get; set; }
        public string POIDescription { get; set; }
        public string NearestCity { get; set; }
        public string NearestVillage { get; set; }
        public string NearestStateHighway { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
