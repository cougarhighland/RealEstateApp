using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public class Hospitals : Institutional
    {
        //constructors
        public Hospitals() { }
        public Hospitals(LocationType lo, string owner) 
        {
            //set value of locationType and entity by setters of Institutional
            LocationType = lo;
            Entity = owner;
        }

    }
}
