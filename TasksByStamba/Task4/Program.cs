namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vehicleCounts = new Dictionary<string, int>();

            Console.Write("Input vehicle count: ");
            int vehicleCount = int.Parse(Console.ReadLine());

            if ( vehicleCount < 1 || vehicleCount > 100 )
            {
                throw new ArgumentException("Vehicle needs to be between 1 and 100");
            }

            for (int i = 0; i < vehicleCount; i++)
            {
                Console.Write("Input vehicle type: ");
                string vehicleType = Console.ReadLine();

                if ( !vehicleCounts.ContainsKey(vehicleType))
                {
                    vehicleCounts[vehicleType] = 0;
                }

                vehicleCounts[vehicleType]++;
            }

            foreach (var catType in vehicleCounts)
            {
                Console.WriteLine($"{catType.Key}: {catType.Value}");
            }
        }
    }
}
