using System .Data;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string typeRoom = Console.ReadLine();
            string packageType = Console.ReadLine();

            if ( destination != "Paris" || destination != "Phuket" || destination != "Mexico" )
            {
                Console.WriteLine("Destination must be Paris, Phuket or Mexico!");

                return;
            }

            if ( typeRoom != "apartment" || typeRoom != "double room" )
            {
                Console.WriteLine("Room Type must be apartment or double room!");

                return;
            }

            if ( packageType != "apartment" || packageType != "double room" )
            {
                Console.WriteLine("Package Type must be regular, all-inclusive or ultra-all-inclusive!");

                return;
            }

            double price = 0;

            switch (destination)
            {
                case "Paris":
                    switch (typeRoom)
                    {
                        case "double room":
                            price = price + 150;

                            break;
                        case "apartment":
                            price = price + 300;

                            break;
                        default:
                            break;
                    }

                    break;
                case "Phyket":
                    switch (typeRoom)
                    {
                        case "double room":
                            price = price + 250;

                            break;
                        case "apartment":
                            price = price + 360;

                            break;
                        default:
                            break;
                    }

                    break;
                case "Mexico":
                    switch (typeRoom)
                    {
                        case "double room":
                            price = price + 220;

                            break;
                        case "apartment":
                            price = price + 310;

                            break;
                        default:
                            break;
                    }

                    break;
            }

            switch (packageType)
            {
                case "all-inclusive":
                    price = price + ( price * 0.3 );

                    break;
                case "ultra-all-inclusive":
                    price = price + ( price * 0.5 );

                    break;
                case "regular":
                    break;
            }

            price = ( price * nights );

            Console.WriteLine($"Total Price: {price:F2}");
        }
    }
}
