using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Commercial
{
    public abstract class Commercial : Estate
    {
        //Fields
        private double area;
        private string orgNr;
        private Parking isAllowParking;
        private int numRooms;
        private CommercialType commercialType;

        //Properties
        public double Area
        { 
            get { return area; } set { area = value; } 
        }
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

        public int NumberOfRooms
        { 
            get { return numRooms; } 
            set { numRooms = value; } 
        }

        public CommercialType CommercialType
        {
            get { return commercialType; }
            set { commercialType = value; }
        }

        // Method to get a string representation of the commercial estate
        public string GetDetails()
        {
            return $"Commercial,{CommercialType},Area {area.ToString()}m^2,Number of Room {numRooms.ToString()},Parking Allowance {isAllowParking},Organization number {orgNr}";
        }
        // Override ToString to combine base ToString with commercial details
        public override string ToString()
        {
            return base.ToString() + GetDetails();
        }
    }
}
