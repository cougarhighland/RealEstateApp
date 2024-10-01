using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public class Warehouse : Commercial
    {
        public Warehouse() { }
        public Warehouse(Parking isAllowParking, string orgNum) 
        {
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }
    }
}
