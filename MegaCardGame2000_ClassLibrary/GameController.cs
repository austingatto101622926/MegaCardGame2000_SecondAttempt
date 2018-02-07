using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCardGame2000_ClassLibrary
{
    public class GameController
    {
        public enum State { CharCreation, PlayerTurn, EnemyTurn, Win, Lose }

        public State GameState;
        public PlayerCharacter Player;
        public NonPlayerCharacter Enemy;
        public Deck Deck;

        public void CreateCharacter(string name, PlayerCharacter.Type type)
        {
            switch (type)
            {
                case PlayerCharacter.Type.Warrior:
                    Player = new Warrior(name);
                    break;
                case PlayerCharacter.Type.Thief:
                    Player = new Thief(name);
                    break;
                case PlayerCharacter.Type.Mage:
                    Player = new Mage(name);
                    break;
            }
        }

        public void StartNewGame()
        {
            Deck = new Deck();
        }

        public void StartNextBattle()
        {
            if (Deck.Count == 0)
            {
                GameState = State.Win;
            }
            else
            {
                Enemy = Deck.NextEnemy();
                if (RNG.Roll_1_In_X(2))
                {
                    GameState = State.PlayerTurn;
                }
                else
                {
                    GameState = State.EnemyTurn;
                }
            }
        }

        public void ResolveEnemyTurn()
        {
            Player.TakeDamage(Enemy.StandardAttack());
            GameState = (Player.CurrentHealth < 1) ? State.Lose : State.PlayerTurn;
        }

        public void ResolvePlayerTurn(int damage)
        {
            Enemy.TakeDamage(damage);
        }
    }
}
