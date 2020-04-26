
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu.GameItems
{
     class Game
    {
        private List<Player> Players { get; set; }
        private int DiceCount { get; set; }

        public Game(List<Player> players, int diceCount)
        {
            Players = players;
            DiceCount = diceCount;
        }

        public void RunGame()
        {
            foreach(Player player in Players)
            {
                player.ThrowDices();
               
                Console.WriteLine($"Player: {player.Name} score: {player.Score}");
                player.ShowDiceScore();
            }
        }
    }
}
 