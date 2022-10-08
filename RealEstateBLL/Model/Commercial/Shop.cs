using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Model.Commercial
{
    [Serializable]
    public class Shop : Commercial
    {
        public Shop()
        {

        }
        public Shop(Address address, int size, LegalForm legalForm, string img, int shelves) : base(address, size, legalForm, img, shelves)
        {

        }
        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((Shop)estate).Address;
            Size = ((Shop)estate).Size;
            LegalForm = ((Shop)estate).LegalForm;
            Img = ((Shop)estate).Img;
            Shelves = ((Shop)estate).Shelves;
        }

        public override string getObjectType()
        {
            return "Shop";
        }
    }
}
