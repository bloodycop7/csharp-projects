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
            string[] evenNumbers = { };

            List<string> evenNumList = evenNumbers.ToList();

            Console.Write("What number would you want the other random numbers to check for even: ");
            string outputParse1 = Console.ReadLine();
            firstNumber = int.Parse(outputParse1);

            Console.Write("How many outputs would you like: ");
            string outputParse = Console.ReadLine();
            outputAmount = int.Parse(outputParse);

            for (int i = 0; i < outputAmount; i++)
            {
                if ( ( firstNumber % i ) != 0 )
                {
                    Console.WriteLine(i + " is even to " + firstNumber);

                    evenNumList.Add(Convert.ToString(i));
                }
                else
                {
                    Console.WriteLine(i + " is not even to " + firstNumber);
                }
                
            }

            Console.WriteLine("All even numbers are:");
            for (int i = 0; i < evenNumList.Count; i++)
            {
                Console.WriteLine(evenNumbers.GetValue(i));
            }
        }
    }
}