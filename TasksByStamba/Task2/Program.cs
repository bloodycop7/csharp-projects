namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Party Price: ");
            double partyPrice = double.Parse(Console.ReadLine());
            int totalItemCount = 0;

            if ( partyPrice < 1.00 || partyPrice > 10000.00 )
            {
                Console.WriteLine("Party Price must be between 1.00 and 10000.00");

                return;
            }

            Console.Write("Input Love Letters Count: ");
            int loveLetters = int.Parse(Console.ReadLine());

            if ( loveLetters < 0 || loveLetters > 1000 )
            {
                Console.WriteLine("Love Letters must be between 0 and 1000");

                return;
            }

            totalItemCount = totalItemCount + loveLetters;

            Console.Write("Input Roses made out of Vosuk Count: ");
            int vosukRozi = int.Parse(Console.ReadLine());

            if ( loveLetters < 0 || loveLetters > 1000 )
            {
                Console.WriteLine("Roses made out of Vosuk must be between 0 and 1000.");

                return;
            }

            totalItemCount = totalItemCount + vosukRozi;

            Console.Write("Input Keychains Count: ");
            int keyChains = int.Parse(Console.ReadLine());

            if ( keyChains < 0 || keyChains > 1000 )
            {
                Console.WriteLine("Keychains must be between 0 and 1000.");

                return;
            }

            totalItemCount = totalItemCount + keyChains;

            Console.Write("Input Kariakaturi Count: ");
            int kariakaturi = int.Parse(Console.ReadLine());

            if ( kariakaturi < 0 || kariakaturi > 1000 )
            {
                Console.WriteLine("Kariakaturi must be between 0 and 1000.");

                return;
            }

            totalItemCount = totalItemCount + kariakaturi;


            Console.Write("Input Surprise Gifts Count: ");
            int surpriseGifts = int.Parse(Console.ReadLine());

            if ( surpriseGifts < 0 || surpriseGifts > 1000 )
            {
                Console.WriteLine("Surprise Gifts must be between 0 and 1000.");

                return;
            }

            totalItemCount = totalItemCount + surpriseGifts;
            double totalCost = ( loveLetters * 0.60 ) + ( vosukRozi * 7.20 ) + ( keyChains * 3.60 ) + ( kariakaturi * 18.20 ) + ( surpriseGifts * 22 );

            if ( totalItemCount >= 25 )
            {
                totalCost = totalCost - ( totalCost * 0.35 );
            }

            totalCost = totalCost - ( totalCost * 0.10 );
            totalCost = totalCost - partyPrice;

            Console.WriteLine(totalCost);
        }
    }
}
