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
    }
}
