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
        //Fields
        private double area;
        private int numRooms;
        private CommercialType commercialType;

        //Properties
        public double Area
        { 
            get { return area; } set { area = value; } 
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
        public abstract override string GetDetails();

        // Override ToString to combine base ToString with commercial details
        public override string ToString()
        {
            return base.ToString() + GetDetails();
        }
    }
}
