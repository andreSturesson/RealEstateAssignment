using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Address
    {
        private string street;
        private string city;
        private int zipcode;
        private string country;

        public Address(string street, string city, int zipcode, string country)
        {
            this.street = street;
            this.city = city;
            this.zipcode = zipcode;
            this.country = country;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
        public string Country { get => country; set => country = value; }
    }
}
