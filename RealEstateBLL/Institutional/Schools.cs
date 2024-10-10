using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Institutional
{
    public class Schools: Institutional
    {
        //constructors
        public Schools() { }
        public Schools(LocationType lo, string owner)
        {
            //set value of locationType and entity by setters of Institutional
            LocationType = lo;
            Entity = owner;
        }
    }
}
