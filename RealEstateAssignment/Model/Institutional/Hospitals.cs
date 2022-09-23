using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment

{
    internal class Hospitals : Institutional
    {
        public Hospitals()
        {

        }
        public Hospitals(Address address, int size, LegalForm legalForm, string img, int capacity) : base(address, size, legalForm, img, capacity)
        {

        }
        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((Hospitals)estate).Address;
            Size = ((Hospitals)estate).Size;
            LegalForm = ((Hospitals)estate).LegalForm;
            Img = ((Hospitals)estate).Img;
            Capacity = ((Hospitals)estate).Capacity;
        }

        public override string getObjectType()
        {
            return "Hospitals";
        }
    }
}
