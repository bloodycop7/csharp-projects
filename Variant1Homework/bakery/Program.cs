using System.ComponentModel;

namespace bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pitkaPrice = double.Parse(Console.ReadLine());

            if ( pitkaPrice < 0.01 ||  pitkaPrice > 1000 )
            {
                Console.WriteLine("Price for one pitka must be between 0.01 and 1000");

                return;
            }

            int pitkaCount = int.Parse(Console.ReadLine());

            if ( pitkaCount < 0 || pitkaCount > 100 )
            {
                Console.WriteLine("Pitka Count must be between 0 and 100");

                return;
            }

            int easterBreadCount = int.Parse(Console.ReadLine());

            if ( easterBreadCount < 0 || easterBreadCount > 100 )
            {
                Console.WriteLine("Easter Bread Count must be between 0 and 100");

                return;
            }

            int gevrekCount = int.Parse(Console.ReadLine());

            if ( gevrekCount < 0 || gevrekCount > 100 )
            {
                Console.WriteLine("Gevrek Count must be between 0 and 100");

                return;
            }

            int kroasani = int.Parse(Console.ReadLine());

            if ( kroasani < 0 || kroasani > 100 )
            {
                Console.WriteLine("Kroasani Count must be between 0 and 100");

                return;
            }

            double budget = double.Parse(Console.ReadLine());

            if ( budget < 0.01 || budget > 1000.00 )
            {
                Console.WriteLine("Budget must be between 0.01 and 1000.00");

                return;
            }

            double kozunakPrice = pitkaPrice + ( pitkaPrice * 0.20 );
            double gevrekPrice = kozunakPrice - ( kozunakPrice * 0.40 );
            double korasanPrice = gevrekPrice + 1.20;

            double totalPrice = (pitkaCount * pitkaPrice) + (easterBreadCount * kozunakPrice) + (gevrekCount * gevrekPrice) + (kroasani * korasanPrice);

            string debugText = "[DEBUGGING]\n";
            debugText = debugText + $"[Kozunak Price | Count | ] : {kozunakPrice} | {easterBreadCount} | {kozunakPrice * easterBreadCount}\n";
            debugText = debugText + $"[Korasan Price | Count] : {korasanPrice} | {kroasani} | {korasanPrice * kroasani}\n";
            debugText = debugText + $"[Gevrek Price | Count] : {gevrekPrice} | {gevrekCount} | {gevrekPrice * gevrekCount}\n";
            debugText = debugText + $"[Pitka Price | Count] : {pitkaPrice} | {pitkaCount} | {pitkaPrice * pitkaCount}\n";
            debugText = debugText + $"[Total Price] : {totalPrice}\n";

            string output = "Yes!";
            double equation = budget - totalPrice;

            output = output + $" {equation:F2} leva left.";

            if ( budget < totalPrice )
            {
                equation = -budget + totalPrice;

                output = "No!";
                output = output + $" {equation:F2} leva missing.";
            }

            Console.WriteLine(output);
        }
    }
}
