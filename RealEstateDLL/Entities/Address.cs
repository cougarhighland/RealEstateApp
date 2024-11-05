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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }  
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public Countries country { get; set; }

        public Estate Estate { get; set; }

    }
}
