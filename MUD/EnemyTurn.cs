using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class EnemyTurn
    {
        public void StartEnemyTurn(Player PlayerCar, Enemy EnemyCar)
        {
            Console.WriteLine("now it's the " + EnemyCar.Name + "'s turn");
            Console.ReadKey(true);
            Random rand1 = new Random();
            int randomNumber1 = rand1.Next(1, 4);
            if (randomNumber1 == 1)
            {
                EnemyCar.Damage = (EnemyCar.AttackPow * 4 / PlayerCar.DefensePow);
                Console.WriteLine("the " + EnemyCar.Name + " attacks you");
            }
            else if (randomNumber1 == 2)
            {
                EnemyCar.Damage = (EnemyCar.AttackPow * 4 + EnemyCar.MagicPow * 3 / PlayerCar.DefensePow);
                Console.WriteLine("the " + EnemyCar.Name + " hits you with a magic attack");
            }
            else if (randomNumber1 == 3)
            {
                EnemyCar.Health = EnemyCar.Health + EnemyCar.MagicPow * 3;
                Console.WriteLine("the " + EnemyCar.Name + " heals itself");
            }
            else
            {
                Console.WriteLine("the " + EnemyCar.Name + " fails to attack");
            }

            Console.ReadKey(true);
            if (randomNumber1 == 1 || randomNumber1 == 2)
            {
                if (PlayerCar.Defend == true)
                {
                    EnemyCar.Damage = EnemyCar.Damage / 2;
                }
                else
                {

                }
                PlayerCar.Health = PlayerCar.Health - EnemyCar.Damage;
                Console.WriteLine("you have " + PlayerCar.Health + "HP left");
            }
            else if (randomNumber1 == 3)
            {
                Console.WriteLine("the " + EnemyCar.Name + " has " + EnemyCar.Health + "HP left");
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
