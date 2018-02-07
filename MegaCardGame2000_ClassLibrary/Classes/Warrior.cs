using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Warrior : PlayerCharacter
    {
        public Warrior(string name) : base(name) { }
        public override int SpecialAttck()
        {
            if (RandomNG.Roll_1_In_X(3))
            {
                return baseDamage * 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
