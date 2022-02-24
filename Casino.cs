using System;
using CodeLouisvilleLibrary;
using ConsoleCasino.Craps;

namespace ConsoleCasino
{
    public class Casino : CodeLouisvilleAppBase
    {
        public Casino():base ("Console Casino") { }

        protected override bool Main()
        {
            var menu = new Menu();
            menu.AddMenuItem("1", "Craps");
            menu.AddMenuItem("Q", "Quit");

            string userSelection = Prompt4MenuItem("Select an option", menu);

            Console.WriteLine($"You picked option {userSelection}");

            switch(userSelection)
            {
                case "1":
                    //var rolldie = new Random();
                    //int die1 = rolldie.Next(6) + 1;
                    //int die2 = rolldie.Next(6) + 1;

                    var allDice = new Dice();
                    allDice.RollDice();

                    for (int i = 0;i<allDice.dice.Length;i++)
                        Console.WriteLine($"Die{i+1}: {allDice.dice[i]}");
                    //Console.WriteLine($"You rolled {die1} and {die2}");
                    break;

                case null:
                    break;
            }
                
            return Prompt4YesNo("Do you want to go again? ");
        }

    }
}

