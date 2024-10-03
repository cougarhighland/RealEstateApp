using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public class Factories : Commercial
    {
        //constructors
        public Factories() { }
        public Factories(Parking isAllowParking, string orgNum)
        {
            //set value of isAllowParking and orgnum by setters from Commercial
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }
    }
}
