using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Rowhouse : Villa
    {
        public Rowhouse(int id, Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm) : base(id, address, plot, garage, rooms, size, legalForm)
        {
        }
    }
}
