using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enums;

namespace RealEstateAssignment
{
    [Serializable]
    public class Address
    {
        private string street;
        private string city;
        private int zipCode;
        private countries country;


        public Address(string street, string city, int zipcode, countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipcode;
            this.country = country;
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public countries Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
    }
}
