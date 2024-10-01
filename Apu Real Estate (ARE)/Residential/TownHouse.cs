using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public class TownHouse:Residential
    {
        public TownHouse() { }
        public TownHouse(NotUsed isUsed, int constructionYear)
        {
            NotUsed = isUsed;
            ConstructionYear = constructionYear;
        }
    }
}
