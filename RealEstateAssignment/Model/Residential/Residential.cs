﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal class Residential : Estate
    {
        private int rooms;
        private int size;
        public Residential(int id, Address address) : base(id, address)
        {
        }
    }

}