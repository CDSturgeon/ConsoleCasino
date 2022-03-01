using System;
using CodeLouisvilleLibrary;

namespace ConsoleCasino.Craps
{
    public class Dice
    {
        public int[] dice = new int[5];

        public int[] shooterDie = new int[2];

        public void RollDice()
        {
            for(var i =0; i < 5; i++)
            {
                dice[i] = RollDie();
            }

        }

        private int RollDie()
        {
            var rolldie = new Random();

            return rolldie.Next(6) + 1;

            //return 0;
        }

        public int[] NewShooter()
        {
            Console.WriteLine("New Shooter. Select two die.");
            bool repeat = true;
            do
            {
                RollDice();
                for (var die =0; die<dice.Length; die++)
                    Console.WriteLine($"{die+1}: {dice[die]}");
                Console.Write("\nType R to re-roll or the number of the first die: ");
                string userSelection = Console.ReadLine();

                switch (userSelection.ToUpper())
                {
                    case "1" or "2" or "3" or "4" or "5":
                        shooterDie[0] = Int32.Parse(userSelection)- 1;
                        repeat = false;
                        break;
                    case "R":
                        break;
                    case null:
                        Console.WriteLine("Invalid selection.");
                        Console.ReadKey();
                        break;
                }
            } while (repeat);

            Console.Write("Enter the number of your second die: ");
            Int32.TryParse(Console.ReadLine(),out shooterDie[1]);

            return shooterDie;
        }
    }
}

