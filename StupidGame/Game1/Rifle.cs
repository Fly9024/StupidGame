using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudidGame.Game1
{
    internal class Rifle:Weapon
    {
       
        bool personType=false;

        public Rifle(string name, double damage, double cost, double distance) : base(name, damage, cost, distance)
        {
        }

        public bool PersonType { get { return personType; } }

       
        public double Cost { get => cost;}

        public override void attack()
        {
            Console.WriteLine("Тра-та-та");
        }

        //public static bool operator >(Rifle r1, Rifle r2)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return true;
        //    else return false;
        //}
        //public static bool operator <(Rifle r1, Rifle r2)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return false;
        //    else return true;
        //}
        //public static bool operator >(Rifle r1, Pistol r2)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return true;
        //    else return false;
        //}
        //public static bool operator <(Rifle r1, Pistol r2)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return false;
        //    else return true;
        //}
        // public static bool operator >( Pistol r2, Rifle r1)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return true;
        //    else return false;
        //}
        //public static bool operator <(Pistol r2, Rifle r1)
        //{
        //    if ((r1.distance + r1.damage) / 2 > (r2.distance + r2.damage) / 2)
        //        return false;
        //    else return true;
        //}

       public static explicit operator Knife(Rifle rifle)
        {
            return new Knife(rifle.name, rifle.damage / 5, rifle.cost, 8); 
        }
    }
}
