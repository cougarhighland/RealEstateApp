using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Commercial
{
    public class Hotels:Commercial
    {
        //constructors
        public Hotels() { }
        public Hotels(Parking isAllowParking, string orgNum) 
        {
            //set value of isAllowParking and orgnum by setters from Commercial
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }
    }
}
