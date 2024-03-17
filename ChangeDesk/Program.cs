namespace ChangeDesk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validCurrencyList = { "eth", "xrp", "btc" };
            string currency = Console.ReadLine();

            if ( !validCurrencyList.Contains(currency.ToLower()) )
            {
                Console.WriteLine($"{currency} is not a valid currency, please use eth, xrp or btc.");

                return;
            }

            double euro = double.Parse(Console.ReadLine());

            if ( euro > 1000 )
            {
                euro = euro * 0.10;
            }

            switch (currency.ToLower())
            {
                case "xrp":
                    if ( euro > 1000 & euro < 2500 )
                    {
                        euro = euro * 0.5;
                        Console.WriteLine("Euro is 0.5+");
                    }
                    else if ( euro >= 2500 )
                    {
                        euro = euro * 0.10;
                        Console.WriteLine("Euro is 0.10+");
                    }

                    break;
                case "btc":
                    if ( euro > 10 )
                    {
                        euro = euro * 0.2;
                        Console.WriteLine("Euro is 0.2+");
                    }

                    break;
                default:
                    break;
            }

            Console.WriteLine(currency);
            Console.WriteLine(euro);
        }
    }
}
