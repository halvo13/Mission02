using System;

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            
            int[] rollResults = new int[11];

            Console.WriteLine("Welcome to the dice rolling simulator!\n");
            Console.WriteLine("How many rolls would you like to simulate?\n");

            int numUserRoll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numUserRoll + ".\n");

            

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
                Console.Write((i + 2) + ": ");

                int j = 0;
                while (j < roundPercentRolls)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("\n");
            } //End main For loop
            Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");

        }

    }
}

