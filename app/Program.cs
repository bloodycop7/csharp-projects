using System;

namespace Testing
{
    class Testing
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number >= 0)
            {
                Console.WriteLine("Hi");
            }
            else
            {
                Console.WriteLine("You must input a positive number.");
            }

            Console.ReadKey();
        }
    }
}