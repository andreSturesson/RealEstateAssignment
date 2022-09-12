using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    abstract class Institutional : Estate
    {
        public Institutional(Address address, int size, LegalForm legalForm, string img) : base(address, size, legalForm, img)
        {

        }
    }
}
