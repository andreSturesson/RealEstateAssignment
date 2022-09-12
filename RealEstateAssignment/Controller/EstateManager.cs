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
        private Estate estate;

        public EstateManager(Estate estate)
        {
            this.estate = estate;
        }


        public Estate Estate { get => estate; set => estate = value; }

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
