using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Warehouse : Commercial
    {

        public Warehouse()
        {

        }
        public Warehouse(Address address, int size, LegalForm legalForm, string img, int shelves) : base(address, size, legalForm, img, shelves)
        {

        }
        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((Warehouse)estate).Address;
            Size = ((Warehouse)estate).Size;
            LegalForm = ((Warehouse)estate).LegalForm;
            Img = ((Warehouse)estate).Img;
            Shelves = ((Warehouse)estate).Shelves;
        }

        public override string getObjectType()
        {
            return "Warehouse";
        }
    }
}
