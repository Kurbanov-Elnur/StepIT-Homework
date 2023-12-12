using _26_2.Fabrics.Interfaces;
using _26_2.Model.Classes;
using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Fabrics.Classes;

class SUVFabric : IAutomobileFabric
{
    public T CreateAutomobile( IAutomobile
    {
        return new SUV() as IAutomobile;
    }
}
