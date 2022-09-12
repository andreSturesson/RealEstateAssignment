using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAssignment.Model.Residential;

namespace RealEstateAssignment
{
    class Villa : Residential
    {
        private string plot;
        private bool garage;
        public Villa(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm) : base(address, rooms, size, legalForm)
        {
            this.plot = plot;
            this.garage = garage;
        }

        public string Plot
        {
            get { return plot; }
            set { plot = value; }
        }

        public bool Garage
        {
            get { return garage; }
            set { garage = value; }
        }
    }
}
