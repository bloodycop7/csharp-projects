namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rentPrice = int.Parse(Console.ReadLine());

            if ( rentPrice < 0 || rentPrice > 1000 )
            {
                Console.WriteLine($"The rent price must be {(rentPrice < 0 ? "higher" : "lower")} than {(rentPrice < 0 ? "0": "1000")}");

                return;
            }

            double foodPrice = rentPrice * 3;
            double drinkPrice = foodPrice - (foodPrice * 0.20);
            double decorationPrice = 0.1 * (foodPrice + drinkPrice);
            double totalPrice = rentPrice + foodPrice + drinkPrice + decorationPrice;

            Console.WriteLine($"Food Price: {foodPrice}\nDrink Price: {drinkPrice}\nDecoration Price: {decorationPrice}\nTotal: {Math.Round(totalPrice, 2)}");
        }
    }
}