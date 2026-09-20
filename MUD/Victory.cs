using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Victory
    {
        public void BattleWon(Player PlayerCar)
        {
            Console.WriteLine("You won!");
            Console.ReadKey(true);
            Random Gold = new Random();
            int randomNumberGold = Gold.Next(60, 91);
            PlayerCar.Gold += randomNumberGold;
            Console.WriteLine("You gained " + randomNumberGold + " gold and got stronger!");
            Console.ReadKey(true);
            Console.WriteLine("items you obtained:");

            Items itemdrop = new Items();
            itemdrop.ItemDrop(PlayerCar);

            Console.ReadKey(true);

            switch (PlayerCar.Cclass)
            {
                case "warior":
                    PlayerCar.Cclass = "warior";
                    PlayerCar.AttackPow += 4;
                    PlayerCar.DefensePow += 1;
                    PlayerCar.MagicPow += 2;
                    
                    break;
                case "tank":
                    PlayerCar.Cclass = "tank";
                    PlayerCar.AttackPow += 3;
                    PlayerCar.DefensePow += 2;
                    PlayerCar.MagicPow += 2;
                    
                    break;
                case "mage":
                    PlayerCar.Cclass = "mage";
                    PlayerCar.AttackPow += 2;
                    PlayerCar.DefensePow += 1;
                    PlayerCar.MagicPow += 4;
                   
                    break;
                default:
                    Console.WriteLine("an error occurred while incrementing stats.");
                    break;
            }
            PlayerCar.MaxHealth += 20;
            PlayerCar.Health = PlayerCar.MaxHealth;
            PlayerCar.MaxMagicPoints += 5;

            PlayerStatus check = new PlayerStatus();
            check.StatusCheck(PlayerCar);
        }
    }
}