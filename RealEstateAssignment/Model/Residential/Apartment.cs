using RealEstateAssignment;
using RealEstateAssignment.Model.Residential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    class Apartment : Residential
    {
        private int apartmentNumber;
        public Apartment(Address address, int apartmentNumber, int rooms, int size, LegalForm legalForm) : base(address, rooms, size, legalForm)
        {
            this.apartmentNumber = apartmentNumber;
        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }


    }
}