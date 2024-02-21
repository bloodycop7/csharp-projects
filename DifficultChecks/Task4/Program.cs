namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            if ( day < 100 || day > 200 )
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
