using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal abstract class Institutional : Estate
    {
        public Institutional(int id, Address address) : base(id, address)
        {

        }
    }
}
