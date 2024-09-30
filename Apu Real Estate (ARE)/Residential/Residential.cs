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
        // Private fields
        private int numOfRooms;
        private int numOfFloors;
        private NotUsed notUsed;
        private ResidentialType residentialType;

        // Properties to access private fields
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

        public ResidentialType Type
        {
            get { return residentialType; }
            set { residentialType = value; }
        }

        public NotUsed NotUsed
        {
            get { return notUsed; }
            set { notUsed = value; }
        }
    }
}
