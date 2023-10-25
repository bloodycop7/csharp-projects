namespace Task17
{
    internal class Program
    {
        // Създайте програма, която чете две думи и извежда дали те са равни или различни.
        static void Main(string[] args)
        {
            Console.Write("Input first word: ");
            string word = Console.ReadLine();

            Console.Write("Input second word: ");
            string word2 = Console.ReadLine();

            if ( word == word2)
            {
                Console.WriteLine("Words are same");
            }
            else
            {
                Console.WriteLine("Words are not the same.");
            }

            Console.ReadKey();
        }
    }
}
