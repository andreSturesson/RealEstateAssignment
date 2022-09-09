using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Appartment
{
    internal class Rental : Apartment
    {
        private int rent;
        public Rental(int id, Address address) : base(id, address)
        {
        }
    }
}
