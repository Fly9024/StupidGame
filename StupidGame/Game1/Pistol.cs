using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudidGame.Game1
{
    internal class Pistol
    {
        public string name;
        public double damage;
        double cost;
        public double distance;

        public Pistol(string name, double damage, double cost, double distance)
        {
            this.name = name;
            this.damage = damage;
            this.cost = cost;
            this.distance = distance;
        }
        public void attack()
        {
            Console.WriteLine("Пиф-паф");
        }
    }
}
