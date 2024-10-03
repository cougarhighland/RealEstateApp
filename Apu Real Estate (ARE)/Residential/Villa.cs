using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public class Villa : Residential
    {
        //constructors
        public Villa() { }
        public Villa(NotUsed isUsed, int constructionYear) 
        {
            //set value of NotUsed and ConstructionYear by setters of Residential
            NotUsed = isUsed;
            ConstructionYear = constructionYear;
        }
    }
}
