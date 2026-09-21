using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerTurn
    {
        public void StartPlayerTurn(Player PlayerCar, Enemy EnemyCar, Room RoomSet)
        {
            PlayerCar.Defend = false;
            PlayerCar.HasUsedItem = false;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("it's your turn");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(PlayerCar.Name + " " + PlayerCar.Health + "/" + PlayerCar.MaxHealth + "HP   " + PlayerCar.MagicPoints + "/" + PlayerCar.MaxMagicPoints + "MP");
            Console.WriteLine(EnemyCar.Name + " " + EnemyCar.Health + "/" + EnemyCar.MaxHealth + "HP");

            Console.Write("Choose an action:");
            while (true)
            {
                PlayerCar.Choice = Console.ReadLine();

                if (PlayerCar.Choice == "attack")
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("you attack the enemy");
                    PlayerCar.Damage = (PlayerCar.AttackPow * 2);

                    break;
                }
                else if (PlayerCar.Choice == "fireball")
                {
                    Console.WriteLine("------------------------------------------------------------------------");
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
                    Console.WriteLine("------------------------------------------------------------------------");
                    if (PlayerCar.MagicPoints < 10)
                    {
                        Console.WriteLine("you don't have enough MP");
                    }
                    else 
                    {
                        Console.WriteLine("you cast heal");
                        Console.ReadKey(true);
                        PlayerCar.Health = PlayerCar.Health + (PlayerCar.MagicPow * 4 + 15);
                        PlayerCar.MagicPoints -= 10;
                        Console.WriteLine("you lost 10 MP");
                        Console.ReadKey(true);
                        if (PlayerCar.Health >= PlayerCar.MaxHealth)
                        {
                            PlayerCar.Health = PlayerCar.MaxHealth;
                            Console.WriteLine("your HP was fully restored!");
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
                    Console.WriteLine("------------------------------------------------------------------------");
                    if (PlayerCar.MagicPoints < 15)
                    {
                        Console.WriteLine("you don't have enough MP");
                    }
                    else
                    {
                        Console.WriteLine("you cast kill");
                        Console.ReadKey(true);
                        Random kill = new Random();
                        int randomNumberKill = kill.Next(PlayerCar.MagicPow * 3, PlayerCar.MagicPow * 7);
                        PlayerCar.Damage = randomNumberKill;
                        PlayerCar.MagicPoints -= 15;
                        Console.WriteLine("you lost 15 MP");

                        break;
                    }
                }
                else if (PlayerCar.Choice == "defend")
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    PlayerCar.Defend = true;
                    PlayerCar.MagicPoints += 20;
                    Console.WriteLine("you take a defensive stance and gain 20 MP");
                    break;
                }
                else if (PlayerCar.Choice == "inventory" || PlayerCar.Choice == "item")
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("you open your inventory");
                    Console.ReadKey(true);
                    if (PlayerCar.Inventory.Count == 0)
                    {
                        Console.WriteLine("your inventory is empty");
                    }
                    else
                    {
                        Console.WriteLine("you have the following items in your inventory:");
                        UseItem useItem = new UseItem();
                        useItem.UsePlayerInventoryItem(PlayerCar);
                        if (PlayerCar.HasUsedItem == true)
                        {
                            break;
                        }
                    }
                }
                else if (PlayerCar.Choice == "help")
                {
                    Help help = new Help();
                    help.PlayerHelp(PlayerCar, RoomSet);
                }
                else
                {
                    Console.WriteLine("unknown command. choose an action next time");
                }
            }

            Console.ReadKey(true);

            if (PlayerCar.Choice == "attack" || PlayerCar.Choice == "fireball" || PlayerCar.Choice == "kill")
            {
                Random Crit = new Random();
                int randomNumberCrit = Crit.Next(1, 6);
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
                PlayerCar.Damage -= EnemyCar.DefensePow;
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