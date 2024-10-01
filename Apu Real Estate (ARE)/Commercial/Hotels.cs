using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public class Hotels:Commercial
    {
        public Hotels() { }
        public Hotels(Parking isAllowParking, string orgNum) 
        {
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }
    }
}
