using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    abstract class Commercial : Estate
    {
        public Commercial(Address address, int size, LegalForm legalForm, string img) : base(address, size, legalForm, img)
        {


        }
    }
}
