using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public class Shops : Commercial
    {
        //fields
        private string orgNr;
        private Parking isAllowParking;
        //properties
        public string OrganizationNumber
        {
            get { return orgNr; }
            set { orgNr = value; }
        }

        public Parking AllowParking
        {
            get { return isAllowParking; }
            set { isAllowParking = value; }
        }
        //constructors
        public Shops() { }
        public Shops(Parking isAllowParking, string orgNum)
        {
            //set value of isAllowParking and orgnum by setters from Commercial
            AllowParking = isAllowParking;
            OrganizationNumber = orgNum;
        }

        //method to get details of commercial estate
        public override string GetDetails()
        {
            return $"Commercial,{CommercialType},Area {Area.ToString()}m^2,Number of Room {NumberOfRooms.ToString()},Parking Allowance {isAllowParking},Organization number {orgNr}";
        }
    }
}
