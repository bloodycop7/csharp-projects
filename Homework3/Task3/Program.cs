namespace Task3
{
    internal class Program
    {

        // Напишете програма, която приема цяло число и извежда квадрата му.
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("The square of your number is: {0}", (number * number));
        }
    }
}