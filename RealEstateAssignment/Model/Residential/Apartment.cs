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
        public Apartment(int id, Address address) : base(id, address)
        {

        }
    }
}
