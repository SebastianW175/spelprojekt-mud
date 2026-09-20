using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    internal class Boss
    {
        public void BossBattleStart(Player PlayerCar, Enemy EnemyCar)
        {
            Console.WriteLine("the dungeon boss appears!");
            Console.ReadKey(true);

            PlayerCar.Damage = 0;
            EnemyCar.Name = "Dragon";
            EnemyCar.Dead = false;
            EnemyCar.Health = 700;
            EnemyCar.MaxHealth = 700;
            EnemyCar.AttackPow = 17;
            EnemyCar.MagicPow = 15;

            while (EnemyCar.Dead == false)
            {
                PlayerTurn yourturn = new PlayerTurn();
                yourturn.StartPlayerTurn(PlayerCar, EnemyCar);

                if (EnemyCar.Dead == false)
                {
                    BossTurn bossturn = new BossTurn();
                    bossturn.StartbossTurn(PlayerCar, EnemyCar);
                }
                else
                {

                }
            }
            Victory victory = new Victory();
            victory.BattleWon(PlayerCar);
        }
    }
}
