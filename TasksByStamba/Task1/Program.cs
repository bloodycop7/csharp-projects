namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int galleryRentPrice = int.Parse(Console.ReadLine());

            if ( galleryRentPrice < 0 || galleryRentPrice > 1000 )
            {
                Console.WriteLine("Gallery Rent Price must be between 0 and 1000.");

                return;
            }

            double rewardKurator = galleryRentPrice * 0.6;
            double ketyring = rewardKurator / 3;
            double musiciansPrice = 0.8 * (rewardKurator + ketyring);

            /*
                string debugText = "[DEBUGGING]\n";
                debugText = debugText + $"Kurator: {rewardKurator}\n";
                debugText = debugText + $"Something: {ketyring}\n";
                debugText = debugText + $"Musicians: {musiciansPrice}\n";

                Console.WriteLine(debugText);
            */

            double totalPrice = galleryRentPrice + rewardKurator + ketyring + musiciansPrice;

            Console.WriteLine($"Total Price: {totalPrice}");
        }
    }
}
