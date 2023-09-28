using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int outputAmount;
            List<string> evenNumList = new List<string>();

            Console.Write("How many outputs would you like: ");
            string outputParse = Console.ReadLine();
            outputAmount = int.Parse(outputParse);

            for ( int i = 0; i < outputAmount; i++)
            {
                Random newRandom = new Random();
                try
                {
                    int randomNumber = newRandom.Next(0, 100);

                    if ( randomNumber % 2 == 0 )
                    {

                        evenNumList.Add(Convert.ToString(randomNumber));
                    }
                }
                catch (DivideByZeroException)
                {
                    int randomNumber = newRandom.Next(0, 100);

                    if ( randomNumber % 2 == 0)
                    {
                        evenNumList.Add(Convert.ToString(randomNumber));
                    }
                }
            }

            Console.WriteLine("All even numbers are:");
            for (int i = 0; i < evenNumList.Count; i++)
            {
                Console.WriteLine(evenNumList[i]);
            }

            Console.WriteLine("Largets even number is: " + evenNumList.Max()); // Output the biggest number in our array (List)
        }
    }
}