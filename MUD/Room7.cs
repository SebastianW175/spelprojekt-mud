using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room7
    {
        public void PlayerInRoom7(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "leaning tower";
            RoomSet.north = false;
            RoomSet.west = false;
            RoomSet.east = false;
            RoomSet.south = true;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);
            Console.WriteLine("there is a chest to the north");
            Console.ReadKey(true);

            if (PlayerCar.Battle5 == false)
            {
                Battle battle5 = new Battle();
                Enemy EnemyCar = new Enemy();
                battle5.BattleStart(PlayerCar, EnemyCar, RoomSet);
                PlayerCar.Battle5 = true;
                Console.WriteLine("your still in the " + RoomSet.Name);
                Console.ReadKey(true);
            }

            while (PlayerCar.roomNumber == 6)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a chest to the north");
                        Console.ReadKey(true);
                        if (PlayerCar.Chest3 == false)
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
                        Console.WriteLine("there is a wall to the west"); 
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
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
