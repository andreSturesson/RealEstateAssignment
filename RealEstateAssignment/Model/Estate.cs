using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

        public int Id { get => id; set => id = value; }
        public Address Address { get => address; set => address = value; }

    }
}
