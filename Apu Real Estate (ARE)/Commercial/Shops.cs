using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public class Shops : Commercial
    {
        public Shops() { }
        public Shops(Parking isAllowParking, string orgNum)
        {
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }
    }
}
