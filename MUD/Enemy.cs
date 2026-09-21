using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Enemy
    {
        public string? Name;
        public int Health;
        public int Damage;
        public int MaxHealth;
        public int AttackPow;
        public int DefensePow;
        public int MagicPow;
        public bool Dead;
        public string[]? Enemys = new string[] 
        { 
            "Goblin", 
            "Skeleton", 
            "Wizard" 
        };
    }
}
