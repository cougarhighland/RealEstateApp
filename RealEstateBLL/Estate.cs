using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RealEstateBLL

{
    public class Estate : IEstate
    {
        //fields
    
        private int id;
        private Address address;
        private string imagePath;
        private LegalForm legalForm;
        private EstateType m_EstateType;
        //properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public LegalForm LegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }

        public EstateType EstateType
        {
            get { return m_EstateType; }
            set { m_EstateType = value; }
        }

        // Overridden ToString method
        public override string ToString()
        {
            return $"ID {ID},Address {address.ToString()}, Residential Type {m_EstateType}, Legal Form {legalForm},";
        }

        public virtual string GetDetails() { return ""; }
    }
}
