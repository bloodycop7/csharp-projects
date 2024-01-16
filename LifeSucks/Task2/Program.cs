namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double containerWidth = Math.Clamp(double.Parse(Console.ReadLine()), 1.00, 10.00);
            double containerLength = Math.Clamp(double.Parse(Console.ReadLine()), 1.00, 10.00);
            double containerHeight = Math.Clamp(double.Parse(Console.ReadLine()), 1.00, 10.00);
            double averagePackageHeight = Math.Clamp(double.Parse(Console.ReadLine()), 1.50, 1.90);

            double containerObem = containerWidth * containerLength * containerHeight;
            double packageObem = (averagePackageHeight + 0.40) * 2 * 2;
            double availableSpace = Math.Round(containerObem / packageObem, 0);

            string outputMessage = availableSpace > 10 ? $"The Container is too big." : $"The container holds {availableSpace} packages.";

            Console.WriteLine(outputMessage);
        }
    }
}
