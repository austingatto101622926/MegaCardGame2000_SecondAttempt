using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class NonPlayerCharacter : Character
    {
        public string EnemyType;
        public NonPlayerCharacter(string enemyType, int maxHealth, int baseDamage)
        {
            EnemyType = enemyType;
            MaxHealth = maxHealth;
            this.BaseDamage = baseDamage;
        }
    }
}
