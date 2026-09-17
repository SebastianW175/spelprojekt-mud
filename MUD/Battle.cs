using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Battle
    {
        public void BattleStart(Player PlayerCar, Enemy EnemyCar)
        {
            PlayerCar.Damage = 0;
            Random rand = new Random();
            int randomNumber = rand.Next(1, 4);

            if (randomNumber == 1)
            {
                EnemyCar.Name = "goblin";
                EnemyCar.Dead = false;
                EnemyCar.Health = 75;
                EnemyCar.MaxHealth = 75;
                EnemyCar.AttackPow = 10;
                EnemyCar.MagicPow = 2;
            }
            else if (randomNumber == 2)
            {
                EnemyCar.Name = "wizard";
                EnemyCar.Dead = false;
                EnemyCar.Health = 45;
                EnemyCar.MaxHealth = 45;
                EnemyCar.AttackPow = 5;
                EnemyCar.MagicPow = 10;
            }
            else if (randomNumber == 3)
            {
                EnemyCar.Name = "skeleton";
                EnemyCar.Dead = false;
                EnemyCar.Health = 50;
                EnemyCar.MaxHealth = 50;
                EnemyCar.AttackPow = 7;
                EnemyCar.MagicPow = 5;
            }
            else
            {
                Console.WriteLine("An error occurred while generating the enemy.");
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
            Console.WriteLine("You have defeated the " + EnemyCar.Name + "!");
            Console.ReadKey(true);
        }
    }
}