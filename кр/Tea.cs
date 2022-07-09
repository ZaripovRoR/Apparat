using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class Tea:Drinkable
    {
        public string TypeOfTea;

        public string LevelHotLeafs;
        

        public Tea(string name,string typeOfTea, string levelHotLeafs,long volume,bool isHot,bool gas)
        {
            Name = name;
            TypeOfTea = typeOfTea;
            LevelHotLeafs = levelHotLeafs;
            Volume = volume;
            IsHot = isHot;
            Gas = gas;
            Price = 5;
        }
    }
}
