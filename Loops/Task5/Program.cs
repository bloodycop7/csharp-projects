namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            if (numberCount < 1)
            {
                Console.WriteLine("[Error] Number must be above or equal to 1");
            }

            for (int i = 0; i < numberCount; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(list.Min());
        }
    }
}
