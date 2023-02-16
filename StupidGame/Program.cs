using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StudidGame.Game1;

namespace StupidGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rifle ak47Rifle = new Rifle("АК-47", 50, 1000, 80); 
            Rifle m16Rifle = new Rifle("m-16", 45, 1000, 90);
            Console.WriteLine(m16Rifle > ak47Rifle);

            Knife knife1 = new Knife("Керамбит", 20, 100, 5);
            Knife knife2 = new Knife("Особо острый", 50, 100, 5);
            Console.WriteLine(knife1 > knife2);
            Console.WriteLine(knife2 > ak47Rifle);
            //Person person1 = new Person(true);
            //person1.CurrentVeapon = 1;
            //person1.attack();
            //Person person2 = new Person(false);



            //person1.Rifle = ak47Rifle;
            // person2.Rifle = ak47Rifle;
            //person1.Knife = (Knife)ak47Rifle;

            //Console.WriteLine(person2["Оружие 1"]);

            //person1.CurrentVeapon = 1;
            //person1.attack();
            ////person2.dropWeapon();

            //person1.showInventory();
            //person2.showInventory();


            Console.ReadKey();
        }
    }
}
