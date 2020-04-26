using DiceMenu.GameItems;
using System;
using System.Collections.Generic;

namespace DiceMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player( 0, "Algis", new List<Dice>(){ new Dice(),new Dice(),new Dice() }),
                new Player( 1, "Paulius", new List<Dice>(){ new Dice(),new Dice(),new Dice() }),
                new Player( 2, "Antanas", new List<Dice>(){ new Dice(),new Dice(),new Dice()})
            };

            Game game = new Game(players, 1);
            game.RunGame();
        }
    }
}
