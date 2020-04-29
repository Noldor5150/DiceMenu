using System;
using System.Collections.Generic;
using System.Text;
using DiceMenu.GameItems;

namespace DiceMenu.Controllers
{
    class GameController
    {
        private Game myGame;

        public void StartGame(int playerCount, int diceCount)
        {
            myGame = new Game();
            myGame.CreatePlayers(playerCount, diceCount);
            myGame.RunGame();
        }
    }
}
