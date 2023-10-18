namespace Task19
{
    // Създайте програма, която приема две думи и извежда дали първата дума се съдържа във втората дума.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first word: ");
            string word = Console.ReadLine();

            Console.Write("Input second word: ");
            string word2 = Console.ReadLine();

            if ( word.Contains(word2) )
            {
                Console.WriteLine("Second word is contained in first word.");
            }
            else
            {
                Console.WriteLine("Second word is not contained in first word.");
            }
        }
    }
}