﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Thief : PlayerCharacter
    {
        public Thief(string name) : base(name) { }
        public override int SpecialAttck()
        {
            if (RandomNG.Roll_1_In_X(3))
            {
                return baseDamage * 2;
            }
            else
            {
                return baseDamage/2;
            }
        }
    }
}
