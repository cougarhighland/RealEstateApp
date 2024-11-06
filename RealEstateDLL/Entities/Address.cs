using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDLL.Entities
{
    public class Address
    {
        //automated generate AddressID 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }  
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public Countries country { get; set; }
        // navigation property for the estate associated with the address.
        public Estate Estate { get; set; }

    }
}
