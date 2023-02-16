using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudidGame.Game1
{
    internal class Knife:Weapon
    {
        public Knife(string name, double damage, double cost, double distance) : base(name, damage, cost, distance)
        {
        }

        public override void attack()
        {
            Console.WriteLine("Вжух-вжух");
        }
    }
}
