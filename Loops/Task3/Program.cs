namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double sum = 0;

            if ( numberCount < 1 )
            {
                Console.WriteLine("[Error] Number must be above or equal to 1");
            }

            for ( int i = 0; i < numberCount; i++)
            {
                sum = sum + double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
