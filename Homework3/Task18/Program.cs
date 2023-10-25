namespace Task18
{
    internal class Program
    {
        // Напишете програма, която приема от потребителя цяло число и извежда дали то е положително, отрицателно или нула.
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if ( number > 0 )
                {
                    Console.WriteLine("Number is positive.");
                }
                else if ( number < 0 )
                {
                    Console.WriteLine("Number is negative.");
                }
                else if ( number == 0 )
                {
                    Console.WriteLine("Number is zero.");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number is zero");
            }
        }

        Console.ReadKey();
    }
}
