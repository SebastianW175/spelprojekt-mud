using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room8
    {
        public void PlayerInRoom8(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "abandoned storage";
            RoomSet.north = false;
            RoomSet.west = false;
            RoomSet.east = true;
            RoomSet.south = false;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);
            Console.WriteLine("there is a chest to the west");
            Console.ReadKey(true);

            if (PlayerCar.Battle4 == false)
            {
                Battle battle4 = new Battle();
                Enemy EnemyCar = new Enemy();
                battle4.BattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle4 = true;
                Console.WriteLine("your still in the " + RoomSet.Name);
                Console.ReadKey(true);
            }

            while (PlayerCar.roomNumber == 7)
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
                        Console.WriteLine("there is a chest to the west");
                        Console.ReadKey(true);
                        if (PlayerCar.Chest2 == false)
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
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 5;
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
