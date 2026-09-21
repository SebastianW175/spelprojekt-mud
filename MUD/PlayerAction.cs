using MUD.Art;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerAction
    {
        public void PlayerChoiceAction(Player PlayerCar, Room RoomSet)
        {
            int i = 0;
            while (i < 1)
            {
                Console.Write("what will you do:");
                PlayerCar.Choice = Console.ReadLine();
                switch (PlayerCar.Choice)
                {
                    case "help":
                        Help help = new Help();
                        help.PlayerHelp(PlayerCar, RoomSet);
                        break;
                    case "inventory":
                        Inventory inventory = new Inventory();
                        inventory.PlayerInventory(PlayerCar);
                        break;
                    case "status":
                        PlayerStatus check = new PlayerStatus();
                        check.StatusCheck(PlayerCar);
                        break;
                    case "map":
                        Map map = new Map();
                        map.ShowMapGraphic();
                        break;
                    case "rest":
                        Rest rest = new Rest();
                        rest.PlayerRest(PlayerCar);
                        break;
                    case "north":
                        i = 1;
                        break;
                    case "west":
                        i = 1;
                        break;
                    case "east":
                        i = 1;
                        break;
                    case "south":
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("unknown command");
                        break;
                }
                if (i == 0)
                {
                    Console.WriteLine("your still in the " + RoomSet.Name);
                    Console.ReadKey(true);
                }
            }
        }
    }
}