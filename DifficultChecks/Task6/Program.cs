namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int day = int.Parse(Console.ReadLine());

            if ( day < 1 || day > 7)
            {
                throw new ArgumentException("Argument must be between 1 and 7.");
            }

            Console.WriteLine(weekdays[day + 1]);
        }
    }
}
