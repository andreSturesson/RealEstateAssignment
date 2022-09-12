﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    public class Address
    {
        private string street;
        private string city;
        private int zipCode;
        private string country;


        public Address(string street, string city, int zipcode, string country)
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
            set { 
                if(value.ToString().Length == 5)
                {
                    this.zipCode = value; 
                }
                    
            }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
    }
}
