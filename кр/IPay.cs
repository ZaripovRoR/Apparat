using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal interface IPay
    {
        double GetCost(double price, double contribution,bool Maintenance);
    }
}
