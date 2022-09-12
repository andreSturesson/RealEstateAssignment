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
        public Villa(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm, string img) : base(address, rooms, size, legalForm, img)
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

        public override void Change(Estate estate)
        {
            Address = ((Villa)estate).Address;
            Plot = ((Villa)estate).Plot;
            Garage = ((Villa)estate).Garage;
            Rooms = ((Villa)estate).Rooms;
            Size = ((Villa)estate).Size;
            LegalForm = ((Villa)estate).LegalForm;
        }
    }
}
