using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public abstract class PlayerCharacter : Character
    {
        public enum Type { Warrior, Thief, Mage }

        public string Name;
        public abstract int SpecialAttck();
        public PlayerCharacter(string name)
        {
            Name = name;
            MaxHealth = 50;
        }
    }
}
