using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public abstract class Commercial : Estate
    {
        private double area;
        private string orgNr;
        private Parking isAllowParking;
        private int numRooms;

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

        public override string ToString()
        {
            return $"Area {area.ToString()}m^2, NumRoom {numRooms.ToString()} ,Orgnum: {orgNr}, Parking Allowance: {isAllowParking}.";
        }
    }
}
