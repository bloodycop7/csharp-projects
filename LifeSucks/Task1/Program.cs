namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = Math.Clamp(double.Parse(Console.ReadLine()), 0.01, 100.00);
            int tshirtCount = Math.Clamp(int.Parse(Console.ReadLine()), 0, 100);
            int jacketCount = Math.Clamp(int.Parse(Console.ReadLine()), 0, 100);
            int jeansCount = Math.Clamp(int.Parse(Console.ReadLine()), 0, 100);
            int sweatherCount = Math.Clamp(int.Parse(Console.ReadLine()), 0, 100);
            double budget = Math.Clamp(double.Parse(Console.ReadLine()), 0.01, 1000.00);

            double jacketPrice = Math.Round(tshirtPrice + ( tshirtPrice * .40 ), 2);
            double jeansPrice = Math.Round(jacketPrice - ( jacketPrice * .20 ), 2);
            double sweatherPrice = Math.Round(jeansPrice - 10, 2);

            double totalPrice = ( tshirtPrice * tshirtCount ) + ( jacketPrice * jacketCount ) + ( jeansPrice * jeansCount ) + ( sweatherPrice * sweatherCount );

            string missing = totalPrice < budget ? "enough" : "not enough";
            string more = totalPrice < budget ? "": $"You need {-(budget - totalPrice)} more!";

            Console.WriteLine($"The money is {missing}! {more}");
        }
    }
}
