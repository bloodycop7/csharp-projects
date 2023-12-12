namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputtedNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"The number {inputtedNumber} is {(inputtedNumber % 2 == 0 ? "even" : "odd")}.");
        }
    }
}
