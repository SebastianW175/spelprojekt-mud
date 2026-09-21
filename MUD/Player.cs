using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Player
    {
        public string? Name;
        public string? Choice;
        public string? age;
        public string? Cclass;
        public string? Weapon;
        public string? Armor;
        public string? Ring;
        public int Health;
        public int Gold;
        public int MaxHealth;
        public int AttackPow;
        public int DefensePow;
        public int MagicPow;
        public int MagicPoints;
        public int MaxMagicPoints;
        public int Damage;
        public int roomNumber;
        public bool Defend;
        public bool HasUsedItem;
        public bool HasKey;
        public bool IsInBattle;
        public bool Dead;
        public bool Chest1;
        public bool Chest2;
        public bool Chest3;
        public bool Battle1;
        public bool Battle2;
        public bool Battle3;
        public bool Battle4;
        public bool Battle5;
        public List<string> Inventory = new List<string>();
        public List<string> Weapons = new List<string>();
        public List<string> Armors = new List<string>();
        public List<string> Rings = new List<string>();

    }
}