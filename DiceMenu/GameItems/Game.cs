
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DiceMenu.GameItems
{
     class Game
    {
        public List<Player> Players { get; private set; }
        private List<string> PreviousGameHistory { get; set; }
       
        public Game()
        {
        }

        public void CreatePlayers( int playersCount, int diceCount)
        {
            List<Dice> dices = new List<Dice>();
            for (int i = 0; i < diceCount; i++)
                dices.Add(new Dice());

            Players = new List<Player>();
            for (int y = 1; y <= playersCount; y++)

            {
                Players.Add(new Player(y, $"P{y}", dices));
            }

        }

        public void RunGame()
        {
            PreviousGameHistory = new List<string>();
            string action = "";
            bool IsThereWinner = false;
            do
            {
                foreach (Player player in Players)
                {
                    if (player.IsPlayerInGame)
                    {
                        player.Score = 0;
                        player.ThrowDices();
                        action = $"Player: {player.Name} score: {player.Score}";
                        PreviousGameHistory.Add(action);
                        Console.WriteLine($"Player: {player.Name} score: {player.Score}");
                        Console.ReadKey();
                    }
                }
                int maxScore = Players.Max(player => player.Score);
                Player[] winner = Players.Where(player => player.Score == maxScore).ToArray();
                if (winner.Length == 1)
                {
                    IsThereWinner = true;
                    action = $"Player {winner[0].Name} wins";
                    PreviousGameHistory.Add(action);
                    Console.WriteLine(action);
                    Players.ForEach(player => player.IsPlayerInGame = false);
                }
                else
                {
                    action = "DRAW!!! Start EXTRA ROUND";
                    PreviousGameHistory.Add(action);
                    Console.WriteLine(action);
                    Players.Where(player => player.Score != maxScore).ToList().ForEach(player => player.IsPlayerInGame = false);
                }
            } while (!IsThereWinner);

        }

        public void ShowReplay()
        {
            foreach (string item in PreviousGameHistory )
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
 