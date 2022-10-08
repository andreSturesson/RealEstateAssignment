using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    [Serializable]
    abstract class LegalForm
    {
        public LegalForm()
        {

        }

        public abstract string getType();
    }
}
