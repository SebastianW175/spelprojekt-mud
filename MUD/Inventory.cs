using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Inventory
    {
        public void PlayerInventory(Player PlayerCar)
        {
            int i = 0;
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (string item in PlayerCar.Inventory)
            {
                if (i < 3)
                {
                    Console.Write(item + "     ");
                    i++;
                }
                else
                {
                    i = 0;
                    Console.WriteLine(item);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            Console.Write("what will you do:");
            int ie = 0;
            while (ie < 1)
            {
                PlayerCar.Choice = Console.ReadLine();
                if (PlayerCar.Choice == "exit" || PlayerCar.Choice == "quit")
                {
                    ie = 1;
                }
                else if (PlayerCar.Choice == "item" || PlayerCar.Choice == "use")
                {
                    
                }
                else
                {
                    Console.WriteLine("unknown command");
                }
            }
        }
    }
}
