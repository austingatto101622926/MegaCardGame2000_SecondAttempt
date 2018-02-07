using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Thief : PlayerCharacter
    {
        public Thief(string name) : base(name) { }
        public override int SpecialAttck()
        {
            if (RNG.Roll_1_In_X(3))
            {
                return BaseDamage * 2;
            }
            else
            {
                return BaseDamage/2;
            }
        }
    }
}
