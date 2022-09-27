using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    abstract class Residential : Estate
    {
        private int rooms;

        public Residential()
        {

        }
        public Residential(Address address, int rooms, int size, LegalForm legalForm, string img) : base(address, size, legalForm, img)
        {
            this.rooms = rooms;
        }

        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        
    }

}
