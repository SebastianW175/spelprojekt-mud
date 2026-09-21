using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class TheEnd
    {
        public void GameWon(Player PlayerCar)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Congratulations! You have beaten the game!");
            Console.ReadKey(true);
            Console.WriteLine("you have:");
            Console.ReadKey(true);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Gold: " + PlayerCar.Gold);
            Console.ReadKey(true);
            Console.WriteLine("gear you obtained:");
            if (PlayerCar.Chest1 == true)
            {
                Console.WriteLine("RustySword");
                Console.WriteLine("BrokenArmor");
            }
            if (PlayerCar.Chest2 == true)
            {
                Console.WriteLine("IronRing");
                Console.WriteLine("WarriorArmor");
                PlayerCar.Chest2 = true;
            }
            if (PlayerCar.Chest3 == true)
            {
                Console.WriteLine("SteelSword");
                Console.WriteLine("EmeraldRing");
            }
            Console.ReadKey(true);
            int i = 0;
            Console.WriteLine("items you possess:");
            foreach (string item in PlayerCar.Inventory)
            {
                if (i < 3)
                {
                    Console.Write(item + "     ");
                    i++;
                }
                else
                {
                    i = 0;
                    Console.WriteLine(item);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            Console.ReadKey(true);
            Console.WriteLine("your stats:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(PlayerCar.Name);
            Console.WriteLine("the " + PlayerCar.age + " year old " + PlayerCar.Cclass);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(PlayerCar.Health + "/" + PlayerCar.MaxHealth + "HP   " + PlayerCar.MagicPoints + "/" + PlayerCar.MaxMagicPoints + "MP");
            Console.WriteLine("Attack:" + PlayerCar.AttackPow + "   Defense:" + PlayerCar.DefensePow + "   Magic:" + PlayerCar.MagicPow);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey(true);
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
