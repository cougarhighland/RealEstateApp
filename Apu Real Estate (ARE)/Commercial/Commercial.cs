using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Commercial
{
    public abstract class Commercial : Estate
    {
        private double area;
        private string orgNr;

        public double Area
        { 
            get { return area; } set { area = value; } 
        }
        public string OrganizationNumber 
        { 
            get { return orgNr; } 
            set { orgNr = value; } 
        }

    }
}
