using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public class Apartment: Residential
    {
        public Apartment() { }
        public Apartment(NotUsed isUsed, int construction)
        {
            NotUsed = isUsed;
            ConstructionYear = construction;
        }
    }
}
