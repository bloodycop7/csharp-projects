using System.Linq.Expressions;

namespace ThreeSameNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sameNumbers = true;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ( b != a )
            {
                sameNumbers = false;
            }
            else if ( c != b || c != a )
            {
                sameNumbers = false;
            }

            Console.WriteLine($"These 3 numbers are {(sameNumbers ? "the same" : "different")}");
        }
    }
}
