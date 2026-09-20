using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room2
    {
        public void PlayerInRoom2(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 2";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the main hall");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 1)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar); 
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("you move north");
                        PlayerCar.roomNumber = 2;
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 3;
                        break;
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 4;
                        break;
                    case "south":
                        Console.WriteLine("you move south");
                        PlayerCar.roomNumber = 0;
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}