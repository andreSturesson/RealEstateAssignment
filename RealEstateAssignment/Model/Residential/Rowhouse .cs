using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAssignment;

namespace RealEstateAssignment
{
    internal class Rowhouse : Villa
    {
        public Rowhouse(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm) : base(address, plot, garage, rooms, size, legalForm)
        {
        }
    }
}
