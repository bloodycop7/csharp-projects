namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000; i++)
            {
                if ( i % 10 != 7 )
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
