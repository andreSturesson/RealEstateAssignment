﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment
{
    internal interface IEstate
    {
        String Id { get; set; }
        Address Address { get; set; }
    }
}