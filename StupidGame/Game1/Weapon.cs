using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudidGame.Game1
{
    internal class Weapon
    {
        public string name;
        public double damage;
        public double cost;
        public double distance;

        public Weapon(string name, double damage, double cost, double distance)
        {
            this.name = name;
            this.damage = damage;
            this.cost = cost;
            this.distance = distance;
        }

        public virtual void attack()
        {
            Console.WriteLine("Тра-та-та");
        }

        public static bool operator >(Weapon r1, Weapon r2)
        {
            if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
                return true;
            else return false;
        }
        public static bool operator <(Weapon r1, Weapon r2)
        {
            if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
                return false;
            else return true;
        }
    }
}
