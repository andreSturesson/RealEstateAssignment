using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    abstract class Institutional : Estate
    {
        private int capacity;

        public Institutional()
        {

        }
        public Institutional(Address address, int size, LegalForm legalForm, string img, int capacity) : base(address, size, legalForm, img)
        {
            this.capacity = capacity;
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
    }
}
