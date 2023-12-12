namespace GuessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPass = "s3cr3t!P@ssw0rd";

            string input = Console.ReadLine();

            Console.WriteLine($"{(input == correctPass ? "Welcome!": "Wrong Password!")}");
        }
    }
}
