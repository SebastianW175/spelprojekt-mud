using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Battle
    {
        public void BattleStart(Player PlayerCar, Enemy EnemyCar)
        {
            Console.WriteLine("a enemy appears!");
            Console.ReadKey(true);

            PlayerCar.Damage = 0;
            Random rand = new Random();
            int randomNumber = rand.Next(1, 4);

            if (randomNumber == 1)
            {
                EnemyCar.Name = "goblin";
                EnemyCar.Dead = false;
                EnemyCar.Health = 100;
                EnemyCar.MaxHealth = 100;
                EnemyCar.AttackPow = 10;
                EnemyCar.MagicPow = 2;
            }
            else if (randomNumber == 2)
            {
                EnemyCar.Name = "wizard";
                EnemyCar.Dead = false;
                EnemyCar.Health = 65;
                EnemyCar.MaxHealth = 65;
                EnemyCar.AttackPow = 5;
                EnemyCar.MagicPow = 10;
            }
            else if (randomNumber == 3)
            {
                EnemyCar.Name = "skeleton";
                EnemyCar.Dead = false;
                EnemyCar.Health = 80;
                EnemyCar.MaxHealth = 80;
                EnemyCar.AttackPow = 7;
                EnemyCar.MagicPow = 5;
            }
            else
            {
                Console.WriteLine("but nobody came...?");
                EnemyCar.Dead = true;
            }
            while (EnemyCar.Dead == false)
            {
                PlayerTurn yourturn = new PlayerTurn();
                yourturn.StartPlayerTurn(PlayerCar, EnemyCar);

                if (EnemyCar.Dead == false)
                {
                    EnemyTurn enemyturn = new EnemyTurn();
                    enemyturn.StartEnemyTurn(PlayerCar, EnemyCar);
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