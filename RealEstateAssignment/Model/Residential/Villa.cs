using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    class Villa : Estate
    {
        private string plot;
        private bool garage;
        public Villa(int id, Address address) : base(id, address)
        {
        }
    }
}
