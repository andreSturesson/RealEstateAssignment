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
        private int size;
        private LegalForm legalForm;
        private string img;


        public Estate(Address address, int size, LegalForm legalForm, string img)
        {
            this.id = 1;
            this.address = address;
            this.size = size;
            this.legalForm = legalForm;
            this.img = img;
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
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public LegalForm LegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }
        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public abstract string getObjectType();


        public abstract void Change(Estate estate);

    }
}
