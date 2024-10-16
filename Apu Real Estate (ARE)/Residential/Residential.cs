using Apu_Real_Estate__ARE_.Institutional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public enum NotUsed
    {
        No,
        Yes
    }
    public abstract class Residential : Estate
    {
        // fields
        private int numOfRooms;
        private int numOfFloors;
        private ResidentialType type;
        // Properties
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }

        public int NumOfFloors
        {
            get { return numOfFloors; }
            set { numOfFloors = value; }
        }

        public ResidentialType ResidentialType
        {
            get { return type; }
            set { type = value; }
        }
        // Method to get a string representation of the Residential estate
        public abstract override string GetDetails();

        // Override ToString to combine base ToString with Residential details
        public override string ToString()
        {
            return base.ToString() + GetDetails();
        }
    }
}
