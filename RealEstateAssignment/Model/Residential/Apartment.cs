using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Apartment : Residential
    {
        private int apartmentNumber;
        public Apartment(int id, Address address, int apartmentNumber, int rooms, int size, LegalForm legalForm) : base(id, address, rooms, size, legalForm)
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
