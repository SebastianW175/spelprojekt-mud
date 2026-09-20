using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room3
    {
        public void PlayerInRoom3(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 3";
            RoomSet.north = true;
            RoomSet.west = false;
            RoomSet.east = false;
            RoomSet.south = false;
            Console.WriteLine("you are now in the treasure chamber");
            Console.ReadKey(true);

            if (PlayerCar.Battle5 == false)
            {
                Boss battle5 = new Boss();
                Enemy EnemyCar = new Enemy();
                battle5.BossBattleStart(PlayerCar, EnemyCar);
                PlayerCar.Battle5 = true;
            }

            while (PlayerCar.roomNumber == 2)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a wall to the north");
                        break;
                    case "west":
                        Console.WriteLine("there is a wall to the west");
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        break;
                    case "south":
                        Console.WriteLine("you move south");
                        PlayerCar.roomNumber = 1;
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
