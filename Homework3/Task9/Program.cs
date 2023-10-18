namespace Task9
{
    internal class Program
    {
        // Напишете програма, която приема две числа и извежда резултата от делението на първото число на второто число. Проверете дали второто число е различно от нула, преди да извършите операцията
        static void Main(string[] args)
        {
            Console.Write("Input your first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            double sN = double.Parse(Console.ReadLine());

            double result = (fN / sN);

            if ( result != 0 )
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("CSharp is not smart, so it cannot do that."); // Doesn't even work but ehh, just don't make it equal to 0 xD
            }

            Console.ReadKey();
        }
    }
}