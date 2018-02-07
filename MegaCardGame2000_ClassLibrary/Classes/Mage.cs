using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Mage : PlayerCharacter
    {
        public Mage(string name) : base(name) { }
        public override int SpecialAttck()
        {
            if (RandomNG.Roll_1_In_X(2))
            {
                return baseDamage * 4;
            }
            else
            {
                TakeDamage(baseDamage);
                return 0;
            }
        }
    }
}
