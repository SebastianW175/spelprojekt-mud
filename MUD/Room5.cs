using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room5
    {
        public void PlayerInRoom5(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 5";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the sewer system");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 4)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a chest to the north");
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 1;
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        break;
                    case "south":
                        Console.WriteLine("there is a wall to the south");
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
