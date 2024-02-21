namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            if ( x2 < 1 )
            {
                throw new ArgumentException("Argument must be greater than 0.");
            }

            double y2 = double.Parse(Console.ReadLine());

            if ( y2 < 1)
            {
                throw new ArgumentException("Argument must be greater than 0.");
            }

            double searchX = double.Parse(Console.ReadLine());
            double searchY = double.Parse(Console.ReadLine());

            bool isInside = true;

            if ( searchX < x1 || searchX > x2 )
            {
                isInside = false;
            }

            if ( searchY < y1 || searchY > y2 )
            {
                isInside = false;
            }

            switch (isInside)
            {
                case true:
                    Console.WriteLine("Inside");
                    break;
                case false:
                    Console.WriteLine("Outside");
                    break;
                default:
                    throw new ArgumentException("Invalid Input");
                    break;
            }
        }
    }
}
