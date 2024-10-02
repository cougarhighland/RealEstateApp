using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public class Schools: Institutional
    {
        public Schools() { }
        public Schools(LocationType lo, string owner)
        {
            LocationType = lo;
            Entity = owner;
        }
    }
}
