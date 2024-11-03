using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RealEstateBLL

{
    public abstract class Estate : IEstate
    {
        //fields
        private int id;
        private Address address;
        private string imagePath;
        private LegalForm legalForm;
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

        // Overridden ToString method
        public override string ToString()
        {
            return $"ID {ID},Address {address.ToString()},Legal Form {legalForm},";
        }

        public abstract string GetDetails();
    }
}
