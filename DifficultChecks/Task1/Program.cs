namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            string product = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if ( city == "sofia" )
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(Math.Round(quantity * 0.50, 1));
                        break;
                    case "water":
                        Console.WriteLine(Math.Round(quantity * 0.70, 1));
                        break;
                    case "beer":
                        Console.WriteLine(Math.Round(quantity * 1.20, 1));
                        break;
                    case "sweets":
                        Console.WriteLine(Math.Round(quantity * 1.45, 1));
                        break;
                    case "peanuts":
                        Console.WriteLine(Math.Round(quantity * 1.60, 1));
                        break;
                    default:
                        throw new ArgumentException("Invalid Product");
                        break;
                }
            }
            else if ( city == "plovdiv" )
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(Math.Round(quantity * 0.40, 1));
                        break;
                    case "water":
                        Console.WriteLine(Math.Round(quantity * 0.70, 1));
                        break;
                    case "beer":
                        Console.WriteLine(Math.Round(quantity * 1.15, 1));
                        break;
                    case "sweets":
                        Console.WriteLine(Math.Round(quantity * 1.30, 1));
                        break;
                    case "peanuts":
                        Console.WriteLine(Math.Round(quantity * 1.50, 1));
                        break;
                    default:
                        throw new ArgumentException("Invalid Product");
                        break;
                }
            }
            else if ( city == "varna" )
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(Math.Round(quantity * 0.45, 1));
                        break;
                    case "water":
                        Console.WriteLine(Math.Round(quantity * 0.70, 1));
                        break;
                    case "beer":
                        Console.WriteLine(Math.Round(quantity * 1.10, 1));
                        break;
                    case "sweets":
                        Console.WriteLine(Math.Round(quantity * 1.35, 1));
                        break;
                    case "peanuts":
                        Console.WriteLine(Math.Round(quantity * 1.55, 1));
                        break;
                    default:
                        throw new ArgumentException("Invalid Product");
                        break;
                }
            }
            else
            {
                throw new ArgumentException("Invalid City");
            }
        }
    }
}
