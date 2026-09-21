using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Boss
    {
        public void BossBattleStart(Player PlayerCar, Enemy EnemyCar, Room RoomSet)
        {
            PlayerCar.IsInBattle = true;
            Console.WriteLine("you are suddenly attacked by the dungeon boss!");
            Console.ReadKey(true);

            PlayerCar.Damage = 0;
            EnemyCar.Name = "Dragon";
            EnemyCar.Dead = false;
            EnemyCar.Health = 700;
            EnemyCar.MaxHealth = 700;
            EnemyCar.AttackPow = 17;
            EnemyCar.DefensePow = 20;
            EnemyCar.MagicPow = 15;

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
                    BossTurn bossturn = new BossTurn();
                    bossturn.StartbossTurn(PlayerCar, EnemyCar);
                }
                else
                {

                }
            }
            VictoryBoss victoryboss = new VictoryBoss();
            victoryboss.BattleWonBoss(PlayerCar);
        }
    }
}
