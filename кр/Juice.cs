using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class Juice:Drinkable
    {
        public string TypeOfJuice { get; set; }
        
        public Juice(string name, string typeOfJuice, long volume, bool isHot, bool gas)
        {
            Name = name;
            TypeOfJuice = typeOfJuice;
            Volume = volume;
            IsHot = isHot;
            Gas = gas;
            Price = 10;
        }
    }
}
