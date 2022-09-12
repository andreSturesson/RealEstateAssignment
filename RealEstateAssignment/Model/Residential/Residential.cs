using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    abstract class Residential : Estate
    {
        private int rooms;
        private int size;
        private LegalForm legalForm;
        public Residential(int id, Address address, int rooms, int size, LegalForm legalForm) : base(id, address)
        {
            this.rooms = rooms;
            this.size = size;
            this.legalForm = legalForm;
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
