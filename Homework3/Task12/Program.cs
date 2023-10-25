namespace Task12
{
    internal class Program
    {
        // Напишете програма, която изисква потребителят да въведе число и извежда дали то е четно или нечетно.
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            double number = double.Parse(Console.ReadLine());

            bool isEven = false;

            if ( number % 2 == 0 )
            {
                isEven = true;
            }

            if ( isEven )
            {
                Console.WriteLine("That number is even!");
            }
            else
            {
                Console.WriteLine("That number is not even!");
            }

            Console.ReadKey();
        }
    }
}
