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
        private int rooms;
        private int size;
        private LegalForm legalForm;
        public Apartment(int id, Address address, int apartmentNumber, int rooms, int size, LegalForm legalForm) : base(id, address)

        {
            this.apartmentNumber = apartmentNumber;
            this.rooms = rooms;
            this.size = size;
            this.legalForm = legalForm;

        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }
        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public LegalForm LegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }
    }
}
