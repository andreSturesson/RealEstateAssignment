using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Model.Residential
{
    internal class Rowhouse : Villa
    {
        public Rowhouse(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm) : base(address, plot, garage, rooms, size, legalForm)
        {

        }
    }
}
