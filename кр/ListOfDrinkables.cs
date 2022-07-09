using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class ListOfDrinkables
    {
        public List<string> arr;
        public ListOfDrinkables(List<string> Drinkables)
        { 
            arr= Drinkables;
        }
        public void CreateList(List<string> arr)
        {

            Tea tea = new Tea("Tea", "Green", "High", 100, true, false);
            Coffe coffe = new Coffe("Coffe", "capuchino", true, 100, true, false);
            Juice juice = new Juice("Juice", "vegatable", 100, false, false);
        }
    }
}
