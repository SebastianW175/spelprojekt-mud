using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Battle
    {
        public void BattleStart(Player PlayerCar, Enemy EnemyCar, Room RoomSet)
        {
            PlayerCar.IsInBattle = true;
            Console.WriteLine("you are suddenly attacked by an enemy!");
            Console.ReadKey(true);

            PlayerCar.Damage = 0;
            Random rand = new Random();
            int randomNumber = rand.Next(1, 4);

            if (randomNumber == 1)
            {
                EnemyCar.Name = EnemyCar.Enemys[0];
                EnemyCar.Dead = false;
                EnemyCar.Health = 100;
                EnemyCar.MaxHealth = 100;
                EnemyCar.AttackPow = 10;
                EnemyCar.DefensePow = 5;
                EnemyCar.MagicPow = 2;
            }
            else if (randomNumber == 2)
            {
                EnemyCar.Name = EnemyCar.Enemys[2];
                EnemyCar.Dead = false;
                EnemyCar.Health = 65;
                EnemyCar.MaxHealth = 65;
                EnemyCar.AttackPow = 5;
                EnemyCar.DefensePow = 2;
                EnemyCar.MagicPow = 10;
            }
            else if (randomNumber == 3)
            {
                EnemyCar.Name = EnemyCar.Enemys[1];
                EnemyCar.Dead = false;
                EnemyCar.Health = 80;
                EnemyCar.MaxHealth = 80;
                EnemyCar.AttackPow = 7;
                EnemyCar.DefensePow = 3;   
                EnemyCar.MagicPow = 5;
            }
            else
            {
                Console.WriteLine("but nobody came...?");
                EnemyCar.Dead = true;
            }

            if (EnemyCar.Dead == false)
            {
                Console.WriteLine("a " + EnemyCar.Name + " appears!");
                Console.ReadKey(true);
            }

            while (EnemyCar.Dead == false)
            {
                if (PlayerCar.Dead == true)
                {
                    Dead dead = new Dead();
                    dead.PlayerDead(PlayerCar, EnemyCar, RoomSet);
                }
                PlayerTurn yourturn = new PlayerTurn();
                yourturn.StartPlayerTurn(PlayerCar, EnemyCar, RoomSet);

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