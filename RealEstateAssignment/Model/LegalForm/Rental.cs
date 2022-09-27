using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    internal class Rental : LegalForm
    {
        private int rent;

        public Rental(int rent)
        {
            this.rent = rent;
        }

        public int Rent
        {
            get { return rent; }
            set { rent = value; }
        }

        public override String getType()
        {
            return "Rental";
        }
    }
}
