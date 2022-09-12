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
        public Apartment(Address address, int apartmentNumber, int rooms, int size, LegalForm legalForm) : base(address, rooms, size, legalForm)
        {
            this.apartmentNumber = apartmentNumber;
        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }
        public override void Change(Estate estate) 
        {
            Address = ((Apartment)estate).Address;
            ApartmentNumber = ((Apartment)estate).ApartmentNumber;
            Rooms = ((Apartment)estate).Rooms;
            Size = ((Apartment)estate).Size;
            LegalForm = ((Apartment)estate).LegalForm;
        }
    }
}
