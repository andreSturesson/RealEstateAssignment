using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment

{
    internal class University : Institutional
    {
        public University(Address address, int size, LegalForm legalForm, string img, int capacity) : base(address, size, legalForm, img, capacity)
        {

        }
        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((University)estate).Address;
            Size = ((University)estate).Size;
            LegalForm = ((University)estate).LegalForm;
            Img = ((University)estate).Img;
            Capacity = ((University)estate).Capacity;
        }

        public override string getObjectType()
        {
            return "University";
        }
    }
}
