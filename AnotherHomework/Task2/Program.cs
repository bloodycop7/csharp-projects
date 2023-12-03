namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double banicaPrice = double.Parse(Console.ReadLine());

            if ( banicaPrice < 0.01 || banicaPrice > 100.00)
            {
                Console.WriteLine($"The banica price must be {(banicaPrice < 0.01 ? "higher": "lower")} than {(banicaPrice < 0.01 ? "0.01": "100.00")}");

                return;
            }

            int banicaAmount = int.Parse(Console.ReadLine());
            var toCheckFor = banicaAmount;

            if ( toCheckFor < 0 || toCheckFor > 100)
            {
                Console.WriteLine($"The banica amount must be {(toCheckFor < 0 ? "higher": "lower")} than {(toCheckFor < 0 ? "0": "100")}");

                return;
            }

            int mekicaAmount = int.Parse(Console.ReadLine());
            toCheckFor = mekicaAmount;

            if ( toCheckFor < 0 || toCheckFor > 100)
            {
                Console.WriteLine($"The mekici amount must be {(toCheckFor < 0 ? "higher": "lower")} than {(toCheckFor < 0 ? "0": "100")}");

                return;
            }

            int kifliAmount = int.Parse(Console.ReadLine());
            toCheckFor = kifliAmount;
                
            if ( toCheckFor < 0 || toCheckFor > 100)
            {
                Console.WriteLine($"The kifli amount must be {(toCheckFor < 0 ? "higher": "lower")} than {(toCheckFor < 0 ? "0": "100")}");

                return;
            }

            int gevreciAmount = int.Parse(Console.ReadLine());
            toCheckFor = gevreciAmount;

            if ( toCheckFor < 0 || toCheckFor > 100)
            {
                Console.WriteLine($"The gevrek amount must be {(toCheckFor < 0 ? "higher": "lower")} than {(toCheckFor < 0 ? "0": "100")}");

                return;
            }

            double budget = double.Parse(Console.ReadLine());

            if ( budget < 0.01 || banicaPrice > 1000.00)
            {
                Console.WriteLine($"The budget must be {(budget < 0.01 ? "higher": "lower")} than {(budget < 0.01 ? "0.01": "1000.00")}");

                return;
            }

            double mekiciPrice = banicaPrice + (banicaPrice * 0.20);
            double kiflaPrice = mekiciPrice - (mekiciPrice * 0.40);
            double gevrekPrice = kiflaPrice + 1.20;

            double totalPrice = Math.Round((banicaPrice * banicaAmount) + (mekiciPrice * mekicaAmount) + (kiflaPrice * kifliAmount) + (gevrekPrice * gevreciAmount), 2);

            // Debugging
            // Console.WriteLine($"Total Price: {totalPrice}\nBudget: {budget}");

            Console.WriteLine($"\n{(budget < totalPrice ? "No!": "Yes!")} {(budget < totalPrice ? Math.Round(totalPrice - budget, 2) + " needed": Math.Round(budget - totalPrice, 2) + " left")}");

            // Debugging
            // Console.WriteLine($"{mekiciPrice} | {kiflaPrice} | {gevrekPrice} | {totalPrice}");
        }
    }
}
