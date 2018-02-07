using System;

namespace MegaCardGame2000_ClassLibrary
{
    public abstract class Character
    {
        public int BaseDamage { get; protected set; } = 10;
        private int _maxHealth;
        public int MaxHealth
        {
            get { return _maxHealth; }
            protected set { _maxHealth = value; CurrentHealth = value; }
        }
        public int CurrentHealth { get; private set; }
        
        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
        }

        public int StandardAttack()
        {
            return BaseDamage;
        }
    }
}
