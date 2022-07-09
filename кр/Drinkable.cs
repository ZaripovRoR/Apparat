using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class Drinkable:IPay
    {   public string Name { get; set; }
        public long Volume { get; set; }
        public bool IsHot { get; set; }
        public bool Gas { get; set; }
        public int Price { get; set; }
        public double GetCost(double priceDrinkable, double contribution, bool Maintenance)
        {
            priceDrinkable= priceDrinkable*TryGetValue("S", )
            if (Maintenance ==true)
            {
                Console.WriteLine("Техобслуживание");
                return contribution;
            }
            if (priceDrinkable> contribution)
            {
                Console.WriteLine("HaveNotMoneyException");
                return 0 ;
            }
            else
            {
                Console.WriteLine("Сдача: " + (contribution- priceDrinkable));
                return (contribution - priceDrinkable);
            }
        }
        public bool GetSize()
        { 
        return false;
        }

    }
}
