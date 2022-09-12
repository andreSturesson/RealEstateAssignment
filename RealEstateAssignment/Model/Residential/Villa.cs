using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    class Villa : Residential
    {
        private string plot;
        private bool garage;
        public Villa(int id, Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm) : base(id, address, rooms, size, legalForm)
        {
            this.plot = plot;
            this.garage = garage;

        }
    }
}
