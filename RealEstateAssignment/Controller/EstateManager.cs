using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Appartment
{

    //Will later contain a collection of estates
    class EstateManager
    {
        private Estate state;

        public EstateManager(Estate state)
        {
            Estate = state;
        }

        public Estate Estate { get => state; set => state = value; }

        public int addEstate(String type)
        {


            return 0;
        }
        public int editEstate()
        {

            return 0;
        }
        public int removeEstate()
        {

            return 0;
        }
    }
}
