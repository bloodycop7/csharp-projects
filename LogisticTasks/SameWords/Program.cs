namespace SameWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            a = a.ToLower();
            b = b.ToLower();

            Console.WriteLine($"{(a == b ? "Yes" : "No")}");
        }
    }
}
