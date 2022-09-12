using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Ownership : LegalForm
    {
        private int value;

        public Ownership(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get { return value; }
            set { value = value; }
        }
    }
}
