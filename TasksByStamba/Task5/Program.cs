namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            if ( firstNumber < 1 || firstNumber > 9)
            {
                throw new ArgumentException("First number must be between 1 and 9");
            }

            if ( firstNumber % 2 != 0 )
            {
                throw new ArgumentException("First number must be even!");
            }

            Console.Write("Input second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int[] allowedSecondNumbers = {2, 3, 5, 7};

            if ( secondNumber < 1 || secondNumber > 9)
            {
                throw new ArgumentException("Second number must be between 1 and 9");
            }

            if ( !allowedSecondNumbers.Contains(secondNumber) )
            {
                throw new ArgumentException("Second number must be 2, 3, 5 or 7");
            }

            Console.Write("Input third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if ( thirdNumber < 1 || thirdNumber > 9)
            {
                throw new ArgumentException("Third number must be between 1 and 9");
            }

            if ( thirdNumber % 2 != 0 )
            {
                throw new ArgumentException("Third number must be even!");
            }
        }
    }
}
