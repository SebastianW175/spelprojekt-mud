using MUD.Art;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class PlayerAction
    {
        public void PlayerChoiceAction(Player PlayerCar)
        {
            Console.WriteLine("what will you do?");
            int i = 0;
            while (i < 1)
            {
                PlayerCar.Choice = Console.ReadLine();
                switch (PlayerCar.Choice)
                {
                    case "help":
                        
                        break;
                    case "inventory":
                        
                        break;
                    case "status":
                        PlayerStatus check = new PlayerStatus();
                        check.StatusCheck(PlayerCar);
                        break;
                    case "map":
                        Map map = new Map();
                        map.ShowMapGraphic();
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
            }
        }
    }
}