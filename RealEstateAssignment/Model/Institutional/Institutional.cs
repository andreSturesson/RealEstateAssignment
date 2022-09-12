using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Model.Institutional
{
    abstract class Institutional : Estate
    {
        public Institutional(Address address) : base(address)
        {

        }
    }
}
