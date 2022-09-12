using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Shop : Commercial
    {
        public Shop(Address address, int size, LegalForm legalForm, string img, int shelves) : base(address, size, legalForm, img, shelves)
        {

        }
        public override void Change(Estate estate)
        {
            Address = ((Shop)estate).Address;
            Size = ((Shop)estate).Size;
            LegalForm = ((Shop)estate).LegalForm;
            Img = ((Shop)estate).Img;
            Shelves = ((Shop)estate).Shelves;
        }
    }
}
