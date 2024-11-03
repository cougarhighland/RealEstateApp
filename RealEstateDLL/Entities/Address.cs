using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDLL.Entities
{
    public class Address
    {
        public int AddressId { get; set; }  
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public Countries country { get; set; }

    }
}
