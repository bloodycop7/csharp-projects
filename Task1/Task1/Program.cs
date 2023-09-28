using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int outputAmount;
            List<string> evenNumList = new List<string>();

            Console.Write("What number would you want the other random numbers to check for even: ");
            string outputParse1 = Console.ReadLine();
            firstNumber = int.Parse(outputParse1);

            Console.Write("How many outputs would you like: ");
            string outputParse = Console.ReadLine();
            outputAmount = int.Parse(outputParse);

            for ( int i = 0; i < outputAmount; i++)
            {
                Random newRandom = new Random();
                try
                {
                    int randomNumber = newRandom.Next(0, 100);

                    if ( firstNumber % randomNumber == 0 )
                    {
                        evenNumList.Add(Convert.ToString(randomNumber));
                    }
                }
                catch (DivideByZeroException)
                {
                    int randomNumber = newRandom.Next(0, 100);

                    if ( firstNumber % randomNumber == 0)
                    {
                        evenNumList.Add(Convert.ToString(randomNumber));
                    }
                }
            }

            Console.WriteLine("All even numbers are:   " + evenNumList.Count);
            for (int i = 0; i < evenNumList.Count; i++)
            {
                Console.WriteLine(evenNumList[i]);
            }
        }
    }
}