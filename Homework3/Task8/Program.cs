namespace Task8
{
    internal class Program
    {

        // Напишете програма, която изисква потребителя да въведе няколко числа, след което извежда тяхната сума и средно аритметично.
        static void Main(string[] args)
        {
            Console.Write("Input your first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            double sN = double.Parse(Console.ReadLine());

            Console.Write("Input your third number: ");
            double tN = double.Parse(Console.ReadLine());

            Console.WriteLine("Total: {0}", (fN + sN + tN));
            Console.WriteLine("Average: {0}", (fN + sN + tN) / 3);
        }
    }
}