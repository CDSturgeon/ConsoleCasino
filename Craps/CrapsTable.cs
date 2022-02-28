using System;
using System.Collections.Generic;
using CodeLouisvilleLibrary;

namespace ConsoleCasino.Craps
{
    public class CrapsTable:CodeLouisvilleAppBase
    {
        public CrapsTable() : base("the Craps Table") { }

        protected override bool Main()
        {
            var shooterMenu = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("S", "Shooter"),
                new KeyValuePair<string, string>("P", "Player")
            };

            string userSelection = Prompt4MenuItem<string>("Choose your role: ", shooterMenu);

            switch (userSelection)
            {
                case "S":

                    //SelectDice();
                    //var allDice = new Dice();
                    //allDice.RollDice();

                    //for (int i = 0; i < allDice.dice.Length; i++)
                    //    Console.WriteLine($"Die{i + 1}: {allDice.dice[i]}");
                    break;

                case "P":
                    break;
            }
            return false;
        }
    }
}