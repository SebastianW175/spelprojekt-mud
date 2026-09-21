using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room3
    {
        public void PlayerInRoom3(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "treasure chamber";
            RoomSet.north = false;
            RoomSet.west = false;
            RoomSet.east = false;
            RoomSet.south = true;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);
            
                Boss battle5 = new Boss();
                Enemy EnemyCar = new Enemy();
                battle5.BossBattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle5 = true;
        }
    }
}
