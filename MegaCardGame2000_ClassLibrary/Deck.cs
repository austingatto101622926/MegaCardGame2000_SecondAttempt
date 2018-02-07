using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Deck
    {
        private static List<NonPlayerCharacter> EnemyTypes = new List<NonPlayerCharacter>()
        {
            new NonPlayerCharacter("Boar",10,7),
            new NonPlayerCharacter("Dragon",200,2),
            new NonPlayerCharacter("Barbarian",18,12),
            new NonPlayerCharacter("Snake",11,5),
            new NonPlayerCharacter("Orc",28,16),
            new NonPlayerCharacter("Goblin",15,6)
        };

        private List<NonPlayerCharacter> Enemies;
        public int Count
        {
            get { return Enemies.Count; }
            set { }
        }

        public Deck()
        {
            Enemies = new List<NonPlayerCharacter>();

            foreach (NonPlayerCharacter Enemy in EnemyTypes)
            {
                int index = (Enemies.Count == 0) ? 0 : RNG.GenIntInRange(0, Enemies.Count);

                Enemies.Insert(index, Enemy);
            }
        }

        public NonPlayerCharacter NextEnemy()
        {
            NonPlayerCharacter NextEnemy = Enemies[0];
            Enemies.RemoveAt(0);
            return NextEnemy;
        }
    }
}
