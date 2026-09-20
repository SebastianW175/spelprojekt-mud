using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Dungeon
    {
        public void DungeonStart(Player PlayerCar, Room RoomSet)
        {
            int i = 0;
            while (i < 1)
            {
                Console.ReadKey(true);
                if (PlayerCar.roomNumber == 0)
                {
                    Room1 room1 = new Room1();
                    room1.PlayerInRoom1(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 1)
                {
                    Room2 room2 = new Room2();
                    room2.PlayerInRoom2(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 2)
                {
                    Room3 room3 = new Room3();
                    room3.PlayerInRoom3(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 3)
                {
                    Room4 room4 = new Room4();
                    room4.PlayerInRoom4(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 4)
                {
                    Room5 room5 = new Room5();
                    room5.PlayerInRoom5(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 5)
                {
                    Room6 room6 = new Room6();
                    room6.PlayerInRoom6(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 6)
                {
                    Room7 room7 = new Room7();
                    room7.PlayerInRoom7(new Room(), PlayerCar);
                }
                else if (PlayerCar.roomNumber == 7)
                {
                    Room8 room8 = new Room8();
                    room8.PlayerInRoom8(new Room(), PlayerCar);
                }
                else
                {
                    Console.ReadKey(true);
                }
            }
        }
    }
}
