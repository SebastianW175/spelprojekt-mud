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
            Console.WriteLine("warior   tank   mage");

            int i = 0;
            while (i < 1)
            {
                PlayerCar.Choice = Console.ReadLine();
                switch (PlayerCar.Choice)
                {
                    case "warior":
                        PlayerCar.Cclass = "warior";
                        PlayerCar.AttackPow = 10;
                        PlayerCar.DefensePow = 3;
                        PlayerCar.MagicPow = 4;
                        i = 1;
                        break;
                    case "tank":
                        PlayerCar.Cclass = "tank";
                        PlayerCar.AttackPow = 9;
                        PlayerCar.DefensePow = 5;
                        PlayerCar.MagicPow = 2;
                        i = 1;
                        break;
                    case "mage":
                        PlayerCar.Cclass = "mage";
                        PlayerCar.AttackPow = 7;
                        PlayerCar.DefensePow = 1;
                        PlayerCar.MagicPow = 10;
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("unknown command. Enter 'warior', 'tank', or 'mage' next time.");
                        break;
                }
            }
            PlayerCar.Health = 100;
            PlayerCar.MaxHealth = 100;
            PlayerCar.MagicPoints = 50;
            PlayerCar.MaxMagicPoints = 50;
        }
    }
}