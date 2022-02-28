using System;
using CodeLouisvilleLibrary;

namespace ConsoleCasino.Blackjack
{
    public class BlackjackTable : CodeLouisvilleAppBase
    {
        public BlackjackTable() : base("the Blackjack Table") { }

        protected override bool Main()
        {
            Console.WriteLine("Sorry, we are still under construction.\n" +
                              "Press any key to return to the main entrance.");
            Console.ReadKey();
            return false;
        }
    }
}