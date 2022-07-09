using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparat
{
    internal class ApparatWithDrinkables
    {

        public double contribution;
        private Dictionary<string, double> _sizes = new Dictionary<string, double>()
        {   { "S", 1   },
            { "M", 1.2 },
            { "L", 1.5 },
            { "XL",1.7 }
        };

        public long ID { get; set; }
        //public List<string> Drinkables = new List<string>();
        public Drinkable[] Drinkables = new Drinkable[3] { new Tea("GreenTea", "Green", "High", 100, true, false), new Coffe("CapuchinoCoffe", "capuchino", true, 100, true, false), new Juice("VegatableJuice", "vegatable", 100, false, false) };

        public bool Maintenance;// Техообслуживание
        public ApparatWithDrinkables(long id, bool maintenance, double contribution)
        {
            ID = id;
            Maintenance = maintenance;
            this.contribution = contribution;
        }

        public void sell(string name, int cost,string size)
        {
            for (int i = 0; i < Drinkables.Length; i++)
            {

                if (name == Drinkables[i].Name)
                {
                    Drinkables[i].GetCost(Drinkables[i].Price, contribution, Maintenance);
                }

            }
        
        }
        public void GiveMenu()
        {
            Console.WriteLine("выберете напиток");
            for (int i = 0; i < Drinkables.Length; i++)
            {
                

                Console.WriteLine(Drinkables[i].Name);
            }
            sell("GreenTea",5,"S");
        }


    }
}
