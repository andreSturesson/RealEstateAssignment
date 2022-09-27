using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    abstract class Commercial : Estate
    {
        private int shelves;

        public Commercial()
        {

        }
        public Commercial(Address address, int size, LegalForm legalForm, string img, int shelves) : base(address, size, legalForm, img)
        {
            this.shelves = shelves;


        }

        public int Shelves
        {
            get { return shelves; }
            set { shelves = value; }
        }
    }
}
