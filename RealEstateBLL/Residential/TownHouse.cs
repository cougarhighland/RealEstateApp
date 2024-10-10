using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Residential
{
    public class TownHouse:Residential
    {
        //constructors
        public TownHouse() { }
        public TownHouse(NotUsed isUsed, int constructionYear)
        {
            //set value of NotUsed and ConstructionYear by setters of Residential
            NotUsed = isUsed;
            ConstructionYear = constructionYear;
        }
    }
}
