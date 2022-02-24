using System;
namespace ConsoleCasino.Craps
{
    public class Dice
    {
        public int[] dice = new int[5];

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
    }
}

