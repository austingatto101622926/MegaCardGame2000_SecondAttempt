using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public static class RandomNG
    {
        private static Random random = new Random();

        public static bool Roll_1_In_X(int x)
        {
            if (random.Next(1, x + 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GenIntInRange(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
