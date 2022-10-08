using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Model
{
    public interface IEstate
    {
        String Id { get; set; }
        Address Address { get; set; }
    }
}
