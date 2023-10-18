namespace Task5
{
    internal class Program
    {

        // Създайте програма, която приема дължина и ширина на правоъгълник и изчислява лицето му, след което го извежда на конзолата
        static void Main(string[] args)
        {

            // Copy Paste from Task 4 (Yes, I am that lazy)

            Console.Write("Input length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Input width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Answer: {0}", (width * length));
        }
    }
}