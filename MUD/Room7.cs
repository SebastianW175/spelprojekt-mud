using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room7
    {
        public void PlayerInRoom7(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 7";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the leaning tower");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 6)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a chest to the north");
                        break;
                    case "west":
                        Console.WriteLine("there is a wall to the west");
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        break;
                    case "south":
                        Console.WriteLine("you move south");
                        PlayerCar.roomNumber = 5;
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
