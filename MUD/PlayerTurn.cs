using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerTurn
    {
        public void StartPlayerTurn(Player PlayerCar, Enemy EnemyCar)
        {
            Console.WriteLine("it's your turn");
            Console.ReadKey(true);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(PlayerCar.Name + " " + PlayerCar.Health + "/" + PlayerCar.MaxHealth + "HP   " + PlayerCar.MagicPoints + "/" + PlayerCar.MaxMagicPoints + "MP");
            Console.WriteLine(EnemyCar.Name + " " + EnemyCar.Health + "/" + EnemyCar.MaxHealth + "HP");

            Console.WriteLine("Choose an action: attack, fireball, heal, kill, defend");
            while (true)
            {
                PlayerCar.Choice = Console.ReadLine();

                if (PlayerCar.Choice == "attack")
                {
                    Console.WriteLine("you attack the enemy");
                    PlayerCar.Damage = (PlayerCar.AttackPow * 2);

                    break;
                }
                else if (PlayerCar.Choice == "fireball")
                {
                    if (PlayerCar.MagicPoints < 20)
                    {
                        Console.WriteLine("you don't have enough MP");
                    }
                    else
                    {
                        Console.WriteLine("you cast fireball");
                        Console.ReadKey(true);
                        PlayerCar.Damage = (PlayerCar.AttackPow * 4 + PlayerCar.MagicPow * 3);
                        PlayerCar.MagicPoints -= 20;
                        Console.WriteLine("you lost 20 MP");
                        break;
                    }     
                }
                else if (PlayerCar.Choice == "heal")
                {
                    if (PlayerCar.MagicPoints < 10)
                    {
                        Console.WriteLine("you don't have enough MP");
                    }
                    else 
                    {
                        Console.WriteLine("you cast heal");
                        Console.ReadKey(true);
                        PlayerCar.Health = PlayerCar.Health + (PlayerCar.MagicPow * 5 + 15);
                        PlayerCar.MagicPoints -= 10;
                        Console.WriteLine("you lost 10 MP");
                        Console.ReadKey(true);
                        if (PlayerCar.Health >= PlayerCar.MaxHealth)
                        {
                            PlayerCar.Health = PlayerCar.MaxHealth;
                            Console.WriteLine("your HP was restored!");
                        }
                        else
                        {
                            Console.WriteLine("you have " + PlayerCar.Health + "HP");
                        }
                        break;
                    }
                }
                else if (PlayerCar.Choice == "kill")
                {
                    if (PlayerCar.MagicPoints < 15)
                    {
                        Console.WriteLine("you don't have enough MP");
                    }
                    else
                    {
                        Console.WriteLine("you cast kill");
                        Console.ReadKey(true);
                        Random kill = new Random();
                        int randomNumberKill = kill.Next(PlayerCar.MagicPow, PlayerCar.MagicPow * 6);
                        EnemyCar.Health -= randomNumberKill;
                        PlayerCar.MagicPoints -= 15;
                        Console.WriteLine("you lost 15 MP");

                        break;
                    }
                }
                else if (PlayerCar.Choice == "Defend")
                {
                    PlayerCar.Defend = true;
                    PlayerCar.MagicPoints += 20;
                    Console.WriteLine("you take a defensive stance and gain 20 MP");
                    break;
                }
                else
                {
                    Console.WriteLine("choose an action next time");
                }
            }

            Console.ReadKey(true);

            if (PlayerCar.Choice == "attack" || PlayerCar.Choice == "fireball" || PlayerCar.Choice == "kill")
            {
                Random Crit = new Random();
                int randomNumberCrit = Crit.Next(1, 8);
                if (randomNumberCrit == 1)
                {
                    PlayerCar.Damage = PlayerCar.Damage * 2;
                    Console.WriteLine("Critical hit!");
                    Console.ReadKey(true);
                    if (PlayerCar.Choice == "kill")
                    {
                        PlayerCar.Damage = 10000;
                    }
                }
                else
                {

                }
                EnemyCar.Health -= PlayerCar.Damage;
                Console.WriteLine("you did " + PlayerCar.Damage + " damage");
                Console.ReadKey(true);
            }
            else
            {

            }
            if (EnemyCar.Health <= 0)
            {
                EnemyCar.Dead = true;
            }
        }
    }
}