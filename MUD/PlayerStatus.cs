using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerStatus
    {
        public void StatusCheck(Player PlayerCar)
        {
            int i = 0;
            while (i < 1)
            {
                PlayerCar.Choice = Console.ReadLine();

                if (PlayerCar.Choice.ToLower() == "y" || PlayerCar.Choice.ToLower() == "yes")
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine(PlayerCar.Name);
                    Console.WriteLine("the " + PlayerCar.age + " year old " + PlayerCar.Cclass);
                    Console.WriteLine("Attack:" + PlayerCar.AttackPow + "   Defense:" + PlayerCar.DefensePow + "   Magic:" + PlayerCar.MagicPow);
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.ReadKey(true);
                    i = 1;
                }
                else if (PlayerCar.Choice.ToLower() == "n" || PlayerCar.Choice.ToLower() == "no")
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
