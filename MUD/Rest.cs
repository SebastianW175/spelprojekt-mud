using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Rest
    {
        public void PlayerRest(Player PlayerCar)
        { 
            if (PlayerCar.roomNumber == 5)
            {
                if (PlayerCar.Health == PlayerCar.MaxHealth && PlayerCar.MagicPoints == PlayerCar.MaxMagicPoints)
                {
                    Console.WriteLine("Your HP and MP are already full.");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("You decide to rest");
                    Console.ReadKey(true);
                    Console.WriteLine("Your HP and MP have been fully restored.");
                    Console.ReadKey(true);
                    PlayerCar.Health = PlayerCar.MaxHealth;
                    PlayerCar.MagicPoints = PlayerCar.MaxMagicPoints;
                }
            }
            else
            {
                Console.WriteLine("You cant rest here");
                Console.ReadKey(true);
            }
        }
    }
}
