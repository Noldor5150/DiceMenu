using System;
using System.Collections.Generic;


namespace DiceMenu.GameItems
{
     class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Dice> Dices { get; set; }
        public bool IsPlayerInGame { get; set; }

        public Player(int id, string name, List<Dice> dices)
        {
            Id = id;
            Name = name;
            Dices = dices;
            IsPlayerInGame = true;
        }

        public void ThrowDices()
        {

            foreach (Dice dice in Dices)
            {
                Random random = new Random();
                dice.EyeNumber = random.Next(1, 6);
                Score += dice.EyeNumber;
            }
        }

        public void ShowDiceScore()
        {
            foreach (Dice dice in Dices)
            {
                Console.WriteLine($"score : {dice.EyeNumber}");
            }
        }
    }
}
