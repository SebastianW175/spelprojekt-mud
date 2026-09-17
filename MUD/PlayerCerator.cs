using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerCerator
    {
        public void PlayerCerate(Player PlayerCar)
        {
            Console.Write("Enter your name:");
            PlayerCar.Name = Console.ReadLine();
            Console.Write("Enter your age:");
            PlayerCar.age = Console.ReadLine();
            Console.WriteLine("Enter your character class:");
            Console.WriteLine("1:warior   2:tank   3:mage");

            int i = 0;
            while (i < 1)
            {
                PlayerCar.Choice = Console.ReadLine();
                PlayerCar.Health = 72;
                PlayerCar.MaxHealth = 100;
                PlayerCar.MagicPoints = 50;
                PlayerCar.MaxMagicPoints = 50;

                if (PlayerCar.Choice == "1")
                {
                    PlayerCar.Cclass = "warior";
                    PlayerCar.AttackPow = 12;
                    PlayerCar.DefensePow = 3;
                    PlayerCar.MagicPow = 5;
                    i = 1;
                }
                else if (PlayerCar.Choice == "2")
                {
                    PlayerCar.Cclass = "tank";
                    PlayerCar.AttackPow = 9;
                    PlayerCar.DefensePow = 5;
                    PlayerCar.MagicPow = 2;
                    i = 1;
                }
                else if (PlayerCar.Choice == "3")
                {
                    PlayerCar.Cclass = "mage";
                    PlayerCar.AttackPow = 7;
                    PlayerCar.DefensePow = 1;
                    PlayerCar.MagicPow = 10;
                    i = 1;
                }
                else
                    Console.WriteLine("type 1, 2 or 3 next time");
            }
        }
    }
}
