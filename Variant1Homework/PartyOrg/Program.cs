namespace PartyOrg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double decorationPrice = int.Parse(Console.ReadLine());

            if ( decorationPrice < 0 || decorationPrice > 999)
            {
                Console.WriteLine("Decoration price must be between 0 and 999!");

                return;
            }

            double pizzaPrice = decorationPrice * 2;
            double drinkPrices = pizzaPrice - ( pizzaPrice * 0.15 );
            double boardGames = ( pizzaPrice + drinkPrices ) / 7;

            /*
                string debugText = "[DEBUGGING]\n";
                debugText = debugText + $"[Decoration Price] : {decorationPrice}\n";
                debugText = debugText + $"[Pizza Price] : {pizzaPrice}\n";
                debugText = debugText + $"[Drink Price] : {drinkPrices}\n";
                debugText = debugText + $"[Board Games] : {boardGames}\n";
            */

            double totalPrice = decorationPrice + pizzaPrice + drinkPrices + boardGames;

            Console.WriteLine(totalPrice);
        }
    }
}
