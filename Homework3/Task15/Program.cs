namespace Task15
{
    internal class Program
    {
        // Създайте програма, която чете дума от потребителя и извежда дължината на думата
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length: {0}", word.Length);

            Console.ReadKey();
        }
    }
}
