﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Model.Institutional

{
    [Serializable]
    public class Schools : Institutional
    {
        public Schools ()
        {

        }
        public Schools(Address address, int size, LegalForm legalForm, string img, int capacity) : base(address, size, legalForm, img, capacity)
        {

        }
        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((Schools)estate).Address;
            Size = ((Schools)estate).Size;
            LegalForm = ((Schools)estate).LegalForm;
            Img = ((Schools)estate).Img;
            Capacity = ((Schools)estate).Capacity;
        }

        public override string getObjectType()
        {
            return "Schools";
        }
    }
}
