using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public abstract class Estate : IEstate
    {
        //define private variables
        private int id;
        private Address address;
        private string imagePath;
        private LegalForm legalForm;

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

        public override string ToString()
        {
            return "(" + ID + ")" + address.ToString();
        }
    }
}
