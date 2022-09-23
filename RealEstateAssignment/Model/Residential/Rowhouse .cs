using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Rowhouse : Villa
    {
        public Rowhouse()
        {

        }
        public Rowhouse(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm, string img) : base(address, plot, garage, rooms, size, legalForm, img)
        {

        }
        public override void Change(Estate estate)
        {
            Address = ((Rowhouse)estate).Address;
            Plot = ((Rowhouse)estate).Plot;
            Garage = ((Rowhouse)estate).Garage;
            Rooms = ((Rowhouse)estate).Rooms;
            Size = ((Rowhouse)estate).Size;
            LegalForm = ((Rowhouse)estate).LegalForm;
            Img = ((Rowhouse)estate).Img;
        }

        public override string getObjectType()
        {
            return "Rowhouse";
        }
    }
}
