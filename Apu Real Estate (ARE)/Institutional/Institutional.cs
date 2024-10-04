using Apu_Real_Estate__ARE_.Commercial;
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
        private InstitutionalType type;

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
        public InstitutionalType InstitutionalType
        {
            get { return type; }
            set { type = value; }
        }
        // Method to get a string representation of the institutional estate
        public string GetDetails()
        {
            return $"Institutional,{type},Area {area.ToString()}m^2,Number of Room {numRooms.ToString()},locationType {locationType},owner {entity}";
        }
        // Override ToString to combine base ToString with institutional details
        public override string ToString()
        {
            return base.ToString() + GetDetails();
        }
    }
}
