using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public class Universities: Institutional
    {
   
        //fields
        private string entity;
        private LocationType locationType;

        //properties
        public LocationType LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }

        public string Entity
        {
            get { return entity; }
            set { entity = value; }
        }
        //constructors
        public Universities() { }
        public Universities(LocationType lo, string owner)
        {
            //set value of locationType and entity
            LocationType = lo;
            Entity = owner;
        }

        public override string GetDetails()
        {
            return $"Institutional,{InstitutionalType},Area {Area.ToString()}m^2,Number of Room {NumberOfRooms.ToString()},locationType {LocationType},owner {entity}";
        }
    }
}

