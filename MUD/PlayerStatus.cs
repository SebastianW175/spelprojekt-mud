using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerStatus
    {
        public Player PlayerCar;
        public void StatusCheck()
        {
            int i = 0;
            while (i < 1)
            {

                PlayerCar.Choice = Console.ReadLine();

                if (PlayerCar.Choice == "y" || PlayerCar.Choice == "yes")
                {
                    PlayerCar.Health = 100;
                    PlayerCar.AttackPow = 12;
                    PlayerCar.DefensePow = 3;
                    PlayerCar.MagicPow = 5;
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine(PlayerCar.Name);
                    Console.WriteLine("the " + PlayerCar.age + " year old " + PlayerCar.Cclass);
                    Console.WriteLine("Attack:" + PlayerCar.AttackPow + "   Defense:" + PlayerCar.DefensePow + "   Magic:" + PlayerCar.MagicPow);
                    Console.WriteLine("------------------------------------------------------------------------");
                    i = 1;
                }
                else if (PlayerCar.Choice == "n" || PlayerCar.Choice == "no")
                {
                    i = 1;
                }
                else
                {
                    Console.WriteLine("type Yes or No next time");
                }
            }
        }
    }
}
