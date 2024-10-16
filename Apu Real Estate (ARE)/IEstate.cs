using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public interface IEstate
    {
        //define the variables
        int ID { get; set; }
        Address Address { get; set; }

        string ImagePath { get; set; }

        LegalForm LegalForm { get; set; }

        public abstract string ToString();

    }
}
