using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class VictoryBoss
    {
        public void BattleWonBoss(Player PlayerCar)
        {
            Console.WriteLine("You won!");
            Console.ReadKey(true);
            Random Gold = new Random();
            int randomNumberGold = Gold.Next(1700, 2001);
            PlayerCar.Gold += randomNumberGold;
            Console.WriteLine("You gained " + randomNumberGold + " gold and got stronger!");
            Console.ReadKey(true);
            Console.WriteLine("items you obtained:");

            Items itemdrop = new Items();
            itemdrop.ItemDrop(PlayerCar);

            Console.ReadKey(true);

            switch (PlayerCar.Cclass)
            {
                case "warrior":
                    PlayerCar.Cclass = "warrior";
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
            PlayerCar.IsInBattle = false;

            TheEnd end = new TheEnd();
            end.GameWon(PlayerCar);
        }
    }
}
