using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Dead
    {
        public void PlayerDead(Player PlayerCar, Enemy EnemyCar, Room RoomSet)
        {
            Console.WriteLine("You have lost all your HP!");
            Console.ReadKey(true);
            Console.WriteLine("You have died!");
            Console.ReadKey(true);
            Console.WriteLine("Game Over");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
