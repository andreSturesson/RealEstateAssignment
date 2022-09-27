using RealEstateAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    class Apartment : Residential
    {
        private int apartmentNumber;

        public Apartment()
        {

        }
        public Apartment(Address address, int apartmentNumber, int rooms, int size, LegalForm legalForm, string img) : base(address, rooms, size, legalForm, img)
        {
            this.apartmentNumber = apartmentNumber;
        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }

        public override void Change(Estate estate)  // set which values ​​can be changed
        {
            Address = ((Apartment)estate).Address;
            ApartmentNumber = ((Apartment)estate).ApartmentNumber;
            Rooms = ((Apartment)estate).Rooms;
            Size = ((Apartment)estate).Size;
            LegalForm = ((Apartment)estate).LegalForm;
            Img = ((Apartment)estate).Img;
        }

        public override string getObjectType()
        {
            return "Apartment";
        }

    }
}