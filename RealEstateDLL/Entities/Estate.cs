using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDLL.Entities
{
    public class Estate
    {
        //primary key for estate
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        public string Category { get; set; }

        // Foreign key for Address
        public int AddressId { get; set; }

        // Navigation property for Address
        public Address Address { get; set; }
        public string ImagePath { get; set; }

        public LegalForm LegalForm { get; set; }


    }
}
