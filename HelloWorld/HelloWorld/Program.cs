using System.Net.Security;
using System.Runtime.ExceptionServices;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task 1
            int outputVar = (3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3;
            Console.WriteLine(outputVar); // Gotta make it look clean :D

            Console.ReadKey();*/

            // Task 2
            // Мързи ме да пиша WriteLine от 1 до 20

            for (int i = 1; i < 21;  i++) // for loop - повтаря едно и също действие докато числото не стигне 21
            {
                Console.WriteLine(i);
            }

            /* Task 3
            int increasedStars = 0;

            for (int i = 0; i < 10; i++)
            {

                for (int i2 = 0; i2 < increasedStars; i2++)
                {
                    Console.Write(".");
                }

                Console.Write(".\n");

                increasedStars++;
            }
            */

            /* Task 4

            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("A | B | Area");
            Console.Write(a + " | " + b + " | " + (a * b));

            */
            
            /* Task 5
                // This is probably the most annoying thing I have EVER done.
                // 9:56 PM: I'm going insane.

            int starCount = int.Parse(Console.ReadLine());

            Console.Write(new string('*', starCount));
            Console.Write("\n");

            for (int i = 0; i < (starCount - 2); i++)
            {
                Console.Write("*" + new string(' ', (starCount - 2)) + "*\n");
            }

            Console.WriteLine(new string('*', starCount));
            */

            Console.ReadKey();
        }
    }
}