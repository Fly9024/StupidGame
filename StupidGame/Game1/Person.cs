using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudidGame.Game1
{
    internal class Person
    {
        bool type;
        Knife knife;
        Pistol pistol;
        Rifle rifle;
        double money;
        int currentVeapon;
       
       public int CurrentVeapon { set { currentVeapon = value; } }
         
        public Rifle Rifle
        {
            get 
            { 
                return rifle!=null? rifle: new Rifle("Оружие отсутствует", 0, 0, 0);
                //if (rifle == null)
                //{
                //    return new Rifle("Оружие отсутствует", 0, 0, 0);
                //}
                //else
                //{
                //    return rifle;
                //}                 
            }
            set
            {
                if(money>=value.Cost && value.PersonType == type)
                {
                    rifle = value;
                    money -= value.Cost;
                }
                else
                {
                    Console.WriteLine("Вы не можете выбрать это оружие");
                }
            }
        }

        internal Pistol Pistol { get => pistol; set => pistol = value; }
        internal Knife Knife { get => knife; set => knife = value; }

        public Person(bool type)
        {
            this.type = type;
            Knife = new Knife("Нож по умолчанию", 10, 0, 5);
            Pistol = new Pistol("Пистолет по умолчанию", 20, 0, 50);
            rifle = null;
            money = 1000;
        }

        public Person(bool type, Knife knife, Pistol pistol, Rifle rifle, int money)
        {
            this.type = type;
            this.Knife = knife;
            this.Pistol = pistol;
            this.rifle = rifle;
            this.money = money;
            currentVeapon = 1;
        }
        public void showInventory()
        {     
            Console.WriteLine("Инвентарь персонажа {0} {1} {2} {3}", Knife.name, Pistol.name,Rifle.name,money);
        }

        public void attack()
        {
            switch (currentVeapon)
            {
                case 1:
                    Knife.attack();
                    break;
                case 2:
                    Pistol.attack();
                    break;
                case 3:
                    Rifle.attack();
                    break;
                default:
                    Console.WriteLine("Я не понимаю");
                    break;
            }
        }

        public void dropWeapon()
        {
            switch (currentVeapon)
            {
                case 1:
                    Knife=null;
                    break;
                case 2:
                    Pistol=null;
                    break;
                case 3:                   
                   rifle = null;                    
                    break;
                default:
                    Console.WriteLine("Я не понимаю");
                    break;
            }  
        }

        public string this[string str]
        {
            get
            {
                switch (str)
                {
                    case "Оружие 1":
                        return knife.name;                      
                    case "Оружие 2":
                        return pistol.name;                      
                    case "Оружие 3":
                        return rifle.name;  
                    default:
                        return "Я не понимаю";                      
                }
            }
        }
    }
}
