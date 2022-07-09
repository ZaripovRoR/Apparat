using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class Coffe : Drinkable
    {
        public string TypeOfCoffe { get; set; }
        public bool Milk;
        
        public Coffe(string name, string typeOfCoffe,bool milk, long volume, bool isHot, bool gas)
        {
            Name = name;
            TypeOfCoffe = typeOfCoffe;
            Milk = milk;
            Volume = volume;
            IsHot = isHot;
            Gas = gas;
            Price = 15;
        }
    }
}
