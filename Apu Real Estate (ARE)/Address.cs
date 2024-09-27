using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public Countries Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }

        public void Update(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zip;
            this.country = country;
        }
        public override string ToString()
        {
            return $"{street}, {zipCode}, {city}, {country.ToString()}";
        }
    }
}
