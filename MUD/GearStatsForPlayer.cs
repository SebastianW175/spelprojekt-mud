using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class GearStatsForPlayer
    {
        public static int RustySword = 2;
        public static int BrokenArmor = 1;
        public static int SteelSword = 5;
        public static int WarriorArmor = 3;
        public static int IronRing = 3;
        public static int EmeraldRing = 6;
        public void CalculatePlayerStats(Player PlayerCar)
        {
            switch(PlayerCar.Choice)
            {
                case "RustySword":
                    PlayerCar.AttackPow = PlayerCar.AttackPow + RustySword;
                    break;
                case "SteelSword":
                    PlayerCar.AttackPow = PlayerCar.AttackPow + SteelSword;
                    break;
                case "BrokenArmor":
                    PlayerCar.DefensePow = PlayerCar.DefensePow + BrokenArmor;
                    break;
                case "WarriorArmor":
                    PlayerCar.DefensePow = PlayerCar.DefensePow + WarriorArmor;
                    break;
                case "IronRing":
                    PlayerCar.MagicPow = PlayerCar.MagicPow + IronRing;
                    break;
                case "EmeraldRing":
                    PlayerCar.MagicPow = PlayerCar.MagicPow + EmeraldRing;
                    break;
            }
            switch(PlayerCar.Weapon)
            {
                case "RustySword":
                    PlayerCar.AttackPow = PlayerCar.AttackPow - RustySword;
                    break;
                case "SteelSword":
                    PlayerCar.AttackPow = PlayerCar.AttackPow - SteelSword;
                    break;
                case "BrokenArmor":
                    PlayerCar.DefensePow = PlayerCar.DefensePow - BrokenArmor;
                    break;
                case "WarriorArmor":
                    PlayerCar.DefensePow = PlayerCar.DefensePow - WarriorArmor;
                    break;
                case "IronRing":
                    PlayerCar.MagicPow = PlayerCar.MagicPow - IronRing;
                    break;
                case "EmeraldRing":
                    PlayerCar.MagicPow = PlayerCar.MagicPow - EmeraldRing;
                    break;
            }
        }
    }
}
