using System.Data;

namespace GuessTheNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int writeInput = AskForNumber();
            int randomNumber = random.Next(1, ( writeInput + 1));

            Console.Write("Select a number from 1 to " + Convert.ToString(writeInput) + ": ");
            string numberInput = Console.ReadLine();

            if ( Convert.ToInt32(numberInput) == randomNumber )
            {
                Win();
            }
            else
            {
                Lose();
            }

            Console.ReadKey();
        }

        static int AskForNumber()
        {
            Console.Write("What would you like your maximum randomized number to be: ");

            string writeInput = Console.ReadLine();

            int returnedValue = int.Parse(writeInput);

            if (returnedValue <= 0 || returnedValue == null)
            {
                Console.WriteLine("You must input a valid number.");

                return -1;
            }

            return returnedValue;
        }

        static void Win()
        {
            Console.WriteLine("You have guessed the number, congratulations!");
        }

        static void Lose()
        {
            Console.WriteLine("You have failed to guess the number, try again!");
        }
    }
}