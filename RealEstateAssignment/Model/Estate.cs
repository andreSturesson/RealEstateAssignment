using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
     abstract class Estate : IEstate
    {
        private int id;
        private Address address;


        public Estate(Address address)
        {
            this.id = 1;
            this.address = address;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
       

        public virtual void Change(Estate estate) { }

    }
}
