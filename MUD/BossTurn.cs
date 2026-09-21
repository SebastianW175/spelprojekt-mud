using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class BossTurn
    {
        public void StartbossTurn(Player PlayerCar, Enemy EnemyCar)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("now it's the " + EnemyCar.Name + "'s turn");
            Console.ReadKey(true);
            Random rand1 = new Random();
            int randomNumber1 = rand1.Next(1, 5);
            if (randomNumber1 == 1 || randomNumber1 == 2)
            {
                EnemyCar.Damage = (EnemyCar.AttackPow * 9 / PlayerCar.DefensePow);
                Console.WriteLine("the " + EnemyCar.Name + " attacks you with its claws");
            }
            else if (randomNumber1 == 3)
            {
                EnemyCar.Damage = (EnemyCar.AttackPow * 4 + EnemyCar.MagicPow * 3 / PlayerCar.DefensePow);
                Console.WriteLine("the " + EnemyCar.Name + " hits you with a fireball");
            }
            else if (randomNumber1 == 4)
            {
                PlayerCar.MagicPoints -= 15;
                Console.WriteLine("the " + EnemyCar.Name + " steals your MP");
            }
            else
            {
                Console.WriteLine("the " + EnemyCar.Name + " fails to attack");
            }

            Console.ReadKey(true);
            if (randomNumber1 == 1 || randomNumber1 == 2 || randomNumber1 == 3)
            {
                if (PlayerCar.Defend == true)
                {
                    EnemyCar.Damage = EnemyCar.Damage / 2;
                }
                else
                {

                }
                Console.WriteLine("you took " + EnemyCar.Damage + " damage");
                PlayerCar.Health = PlayerCar.Health - EnemyCar.Damage;
                Console.WriteLine("you have " + PlayerCar.Health + "HP left");
            }
            else if (randomNumber1 == 4)
            {
                if (PlayerCar.MagicPoints <= 0)
                {
                    Console.WriteLine("you have no MP left");
                    PlayerCar.MagicPoints = 0;
                }
                else
                {
                    Console.WriteLine("you have " + PlayerCar.MagicPoints + "MP left");
                }
            }
            else
            {

            }
            if (PlayerCar.Health <= 0)
            {
                PlayerCar.Dead = true;
            }
            else
            {

            }
            Console.ReadKey(true);
        }
    }
}
