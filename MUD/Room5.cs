using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room5
    {
        public void PlayerInRoom5(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "sewer system";
            RoomSet.north = false;
            RoomSet.west = true;
            RoomSet.east = false;
            RoomSet.south = false;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);
            Console.WriteLine("there is a chest to the north");
            Console.ReadKey(true);

            if (PlayerCar.Battle2 == false)
            {
                Battle battle2 = new Battle();
                Enemy EnemyCar = new Enemy();
                battle2.BattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle2 = true;
                Console.WriteLine("your still in the " + RoomSet.Name);
                Console.ReadKey(true);
            }

            while (PlayerCar.roomNumber == 4)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a chest to the north");
                        Console.ReadKey(true);
                        if (PlayerCar.Chest1 == false)
                        {
                            OpenChest openChest = new OpenChest();
                            openChest.PlayerOpenChest(PlayerCar);
                        }
                        else
                        {
                            Console.WriteLine("...but you have already opened it");
                            Console.ReadKey(true);
                        }
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 1;
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
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
