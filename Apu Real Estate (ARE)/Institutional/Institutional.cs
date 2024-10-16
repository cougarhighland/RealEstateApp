using Apu_Real_Estate__ARE_.Commercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Institutional
{
    public abstract class Institutional: Estate
    {
        //Fields
        private int numRooms;
        private double area;
        private InstitutionalType institutionalType;
        //Properties
        public InstitutionalType InstitutionalType
        {
            get { return institutionalType; }
            set { institutionalType = value; }
        }
  
        public int NumberOfRooms
        {
            get { return numRooms; }
            set { numRooms = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }
 
        // Method to get a string representation of the institutional estate
        public abstract override string GetDetails();
 
        // Override ToString to combine base ToString with institutional details
        public override string ToString()
        {
            return base.ToString() + GetDetails();
        }
    }
}
