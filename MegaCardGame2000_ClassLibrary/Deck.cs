using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class Deck
    {
        private static Dictionary<string, int> EnemyTypes = new Dictionary<string, int>()
        {
            { "Boar", 10 },
            { "Dragon", 100},
            { "Barbarian", 18},
            { "Snake", 11}
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

            foreach (KeyValuePair<string,int> Enemy in EnemyTypes)
            {
                int index = (Enemies.Count == 0) ? 0 : RandomNG.GenIntInRange(0, Enemies.Count);

                Enemies.Insert(index, new NonPlayerCharacter(Enemy.Key, Enemy.Value));
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
