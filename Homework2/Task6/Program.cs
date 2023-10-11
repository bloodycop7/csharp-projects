namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input radians: ");
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;

            Console.WriteLine("Degrees: {0}", Math.Round(deg));
        }
    }
}