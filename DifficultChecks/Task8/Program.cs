namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double cost = 0;

            switch (projectionType)
            {
                case "premiere":
                    cost = 12 * rows * columns;
                    break;
                case "normal":
                    cost = 7.5 * rows * columns;
                    break;
                case "discount":
                    cost = 5 * rows * columns;
                    break;
                default:
                    throw new ArgumentException("Invalid projection type.");
            }

            Console.WriteLine($"{(Math.Round(cost, 2))}");
        }
    }
}
