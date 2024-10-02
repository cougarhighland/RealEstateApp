using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public abstract class Institutional: Estate
    {
        private string entity;
        private LocationType locationType;
        private int numRooms;
        private double area;

        // Properties with getters and setters
        public string Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public LocationType LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }

        public int NumberOfRooms
        {
            get { return numRooms; }
            set { numRooms = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Print()
        {
            return $"Area {area.ToString()}m^2,Number of Room {numRooms.ToString()},locationType {locationType},owner {entity}";
        }
    }
}
