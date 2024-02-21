namespace Task5
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

            if ( y2 < 1 )
            {
                throw new ArgumentException("Argument must be greater than 0.");
            }

            double searchX = double.Parse(Console.ReadLine());
            double searchY = double.Parse(Console.ReadLine());

            double boxWidth = x2 - x1;
            double boxHeight = y2 - y1;

            bool bOnBorder = false;
            bool bInside = true;

            if ( ( searchX == x1 || searchX == x2 && ( searchY > y1 && searchY < y2) ) || ( searchY == y1 || searchY == y1  && ( searchX > x1 && searchX < x2 ) ) )
            {
                bOnBorder = true;
            }

            if (searchX < x1 || searchX > x2)
            {
                bInside = false;
            }

            if (searchY < y1 || searchY > y2)
            {
                bInside = false;
            }

            if (bOnBorder)
            {
                Console.WriteLine("On border");
            }
            else if (bInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
