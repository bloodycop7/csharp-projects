namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            double trapecA = double.Parse(Console.ReadLine());
            double trapecB = double.Parse(Console.ReadLine());
            double trapecHeight = double.Parse(Console.ReadLine());

            double forumTrapec = (trapecA + trapecB) / 2 * trapecHeight;
            double forumSquare = trapecA * trapecA;

            Console.WriteLine("\nOutput: Trapec | Square");
            Console.WriteLine(forumTrapec + " | " + forumSquare + "\n");
            /*
                        if (forumSquare < forumTrapec)
                        {
                            Console.WriteLine("Лицето на {0} е {1} и е с {2} по-малко от лицето на {3}", "Трапецът", forumTrapec, forumTrapec - forumSquare, "квадратът");
                            return;
                        }*/

            Console.WriteLine($"{0} fs");
            Console.WriteLine("Лицето на {0} е {1} и е с {2} по-голямо от лицето на {3}", "Трапецът", forumTrapec, forumSquare < forumTrapec ? forumTrapec - forumSquare : forumSquare - forumTrapec, "квадратът");

           // Console.WriteLine("Лицето на {0} е {1} и е с {2} по-голямо от лицето на {3}", "Трапецът", forumTrapec, forumSquare - forumTrapec, "квадратът");
            Console.ReadKey();
        }
    }
}
