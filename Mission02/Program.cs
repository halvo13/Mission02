using System;

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            
            int[] rollResults = new int[11];

            Console.WriteLine("Welcome to the dice rolling simulator!");
            Console.WriteLine("How many rolls would you like to simulate?");

            int numUserRoll = Convert.ToInt32(Console.ReadLine());

            //Roll the two dice, sum results, add results to array
            for (int i = 0; i < numUserRoll; i++)
            {
                int die1 = r.Next(6);
                int die2 = r.Next(6);

                int sumRoll = die1 + die2;

                rollResults[sumRoll]++;
            }
            //Print out results
            for (int i = 0; i < rollResults.Length; i++)
            {
                double percentRolls = ((Convert.ToDouble(rollResults[i]) / Convert.ToDouble(numUserRoll)) * 100);

                int roundPercentRolls = Convert.ToInt32(Math.Round(percentRolls));
                Console.WriteLine((i + 2) + ": ");

                int j = 0;
                while (j < roundPercentRolls)
                {
                    Console.WriteLine("*");
                    j++;
                }
            } //End main For loop

        }

    }
    }
}
