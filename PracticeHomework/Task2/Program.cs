using System.Security.Authentication;
using System.Security.Principal;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boyPartyPrice = double.Parse(Console.ReadLine());

            double loveLetterPrice = 0.60;
            double vosukRosePrice = 7.20;
            double keyChainPrice = 3.60;
            double karikaturaPrice = 18.20;
            double surpriseGiftPrice = 22;

            if ( boyPartyPrice < 1.00 || boyPartyPrice > 1000.00 )
            {
                Console.WriteLine($"The rent price must be {(boyPartyPrice < 1.00 ? "higher" : "lower")} than {(boyPartyPrice < 1.00 ? "1.00": "10000.00")}");

                return;
            }

            int loveLetters = int.Parse(Console.ReadLine());

            if ( loveLetters < 0 || loveLetters > 1000 )
            {
                Console.WriteLine($"The love letters must be {(loveLetters < 0 ? "higher" : "lower")} than {(loveLetters < 0 ? "0": "1000")}");

                return;
            }

            int vosucRoses = int.Parse(Console.ReadLine());

            if ( vosucRoses < 0 || vosucRoses > 1000 )
            {
                Console.WriteLine($"The roses made out of vosuc must be {(vosucRoses < 0 ? "higher" : "lower")} than {(vosucRoses < 0 ? "0": "1000")}");

                return;
            }

            int keyChain = int.Parse(Console.ReadLine());

            if ( keyChain < 0 || keyChain > 1000 )
            {
                Console.WriteLine($"The keychains must be {(keyChain < 0 ? "higher" : "lower")} than {(keyChain < 0 ? "0": "1000")}");

                return;
            }

            int karikatura = int.Parse(Console.ReadLine());

            if ( karikatura < 0 || karikatura > 1000 )
            {
                Console.WriteLine($"The карикатури must be {(karikatura < 0 ? "higher" : "lower")} than {(karikatura < 0 ? "0": "1000")}");

                return;
            }

            int surpriseGifts = int.Parse(Console.ReadLine());

            if ( surpriseGifts < 0 || surpriseGifts > 1000 )
            {
                Console.WriteLine($"The Surprise Gifts must be {(surpriseGifts < 0 ? "higher" : "lower")} than {(surpriseGifts < 0 ? "0": "1000")}");

                return;
            }

            double totalPrice = (loveLetters * loveLetterPrice) + (vosucRoses * vosukRosePrice) + (keyChain * keyChainPrice) + (karikatura * karikaturaPrice) + (surpriseGifts * surpriseGiftPrice);
            totalPrice = Math.Round(totalPrice, 2);

            double discount = 0;

            if ( loveLetters + vosucRoses + keyChain + karikatura + surpriseGifts >= 25 )
            {
                discount = 0.35  * totalPrice;
            }

            totalPrice = totalPrice - discount;

            double razhod = 0.10 * totalPrice;
            double win = totalPrice - razhod;
            
            // Console.WriteLine($"[DEBUGGING]\n{loveLetters} - {loveLetterPrice} : {loveLetters * loveLetterPrice}\n{vosucRoses} - {vosukRosePrice} : {vosucRoses * vosukRosePrice}\n{keyChain} - {keyChainPrice} : {keyChain * keyChainPrice}\n{surpriseGifts} - {surpriseGiftPrice} : {surpriseGifts * surpriseGiftPrice}\n\n[TOTAL PRICE] : {totalPrice}\n[RAZHOD] : {(0.10 * totalPrice)}\n[WIN] : {win}\n[DISCOUNT] : {discount}\n[ITEM COUNT] : {loveLetters + vosucRoses + keyChain + karikatura + surpriseGifts}");

            // Console.WriteLine($"[LAST DEBUG] : {win} - {boyPartyPrice} : {win + boyPartyPrice}");

            if ( win >= boyPartyPrice)
            {
                Console.WriteLine($"Yes! Money Remaining: {(Math.Round(win - boyPartyPrice, 2))}");
            }
            else
            {
                Console.WriteLine($"No! Money Needed: {(Math.Round(boyPartyPrice - win, 2))}");
            }

            // IT TOOK ME UNTIL 1:14 AM TO FINISH THIS. I HATE THIS KIND OF TASKS!!!
        }
    }
}
