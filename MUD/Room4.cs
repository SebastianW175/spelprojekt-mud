using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room4
    {
        public void PlayerInRoom4(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "resting grounds";
            RoomSet.north = false;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = false;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);

            if (PlayerCar.Battle3 == false)
            {
                Battle battle3 = new Battle();
                Enemy EnemyCar = new Enemy();
                battle3.BattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle3 = true;
                Console.WriteLine("your still in the " + RoomSet.Name);
                Console.ReadKey(true);
            }

            while (PlayerCar.roomNumber == 3)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a wall to the north");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 5;
                        break;
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 1;
                        break;
                    case "south":
                        Console.WriteLine("there is a wall to the south");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
