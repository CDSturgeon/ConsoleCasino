using System;
using CodeLouisvilleLibrary;
using ConsoleCasino.Craps;
using ConsoleCasino.Blackjack;

namespace ConsoleCasino
{
    public class Casino : CodeLouisvilleAppBase
    {
        public Casino():base ("the Console Casino") { }

        protected override bool Main()
        {
            var menu = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("1", "Craps"),
                new KeyValuePair<string, string>("2", "Blackjack"),
                new KeyValuePair<string, string>("Q", "Quit")
            };

            string userSelection = Prompt4MenuItem<string>("Select an option", menu);

            switch (userSelection)
            {
                case "1":
                    var craps = new CrapsTable();
                    craps.Run();
                    Wait();
                    return true;

                case "2":
                    var blackjack = new BlackjackTable();
                    blackjack.Run();
                    Wait();
                    return true;

                case "Q":
                    return false;

                case null:
                    Console.WriteLine("Invalid selection.");
                    return true;
            }

            return Prompt4YesNo("Do you want to go again? (Y/N): ");
        }
    }
}