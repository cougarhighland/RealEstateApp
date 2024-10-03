using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public abstract class Institutional: Estate
    {
        //Fields
        private string entity;
        private LocationType locationType;
        private int numRooms;
        private double area;

        //Properties
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
        // Method to get a string representation of the institutional estate
        public string GetDetails()
        {
            return $"Area {area.ToString()}m^2,Number of Room {numRooms.ToString()},locationType {locationType},owner {entity}";
        }
    }
}
