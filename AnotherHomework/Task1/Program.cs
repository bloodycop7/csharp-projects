namespace Task1
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Write("Input Number 0-1000: ");
            double num = double.Parse(Console.ReadLine());
            
            double smthidk = num * 2;
            double drinks = smthidk - ( smthidk * 0.15 );

            Console.WriteLine($"{smthidk} | {drinks}");

            double giftPrice = (smthidk + drinks) / 7;

            // I can clamp the num value, but I want an if statement for going over the given limit.

            if ( num > 1000 )
            {
                Console.WriteLine($"Your number must not go over 1000. Inputted number: {num}");

                return;
            }
            else if ( num < 0 )
            {
                Console.WriteLine($"Your number must not go below 0. Inputted number: {num}");

                return;
            }

            Console.WriteLine(Math.Round(num + smthidk + drinks + giftPrice, 2));
        }
    }
}