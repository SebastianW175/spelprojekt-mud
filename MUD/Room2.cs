using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room2
    {
        public void PlayerInRoom2(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "main hall";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);
            Console.WriteLine("there is a door to the north. It looks important...");
            Console.ReadKey(true);

            if (PlayerCar.Battle1 == false)
            {
                Battle battle1 = new Battle();
                Enemy EnemyCar = new Enemy();
                battle1.BattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle1 = true;
                Console.WriteLine("your still in the " + RoomSet.Name);
                Console.ReadKey(true);
            }

            while (PlayerCar.roomNumber == 1)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet); 
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("you move to the door");
                        if (PlayerCar.HasKey == true)
                        {
                            DungeonDoor dungeonDoor = new DungeonDoor();
                            dungeonDoor.OpenDungeonDoor(RoomSet, PlayerCar);
                        }
                        else
                        {
                            Console.WriteLine("the door is locked");
                            Console.ReadKey(true);
                            Console.WriteLine("you go back");
                            Console.ReadKey(true);
                        }
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