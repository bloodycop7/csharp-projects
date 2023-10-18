namespace Task10
{
    internal class Program
    {
        // Създайте калкулатор, който извършва събиране, изваждане, умножение и деление върху две въведени числа.
        static double Calculator(string action, double fN, double sN)
        {
            double result = 0;

            if ( action == "p" || action == "+" || action == "plus")
            {
                result = fN + sN;
            }
            else if ( action == "t" || action == "take" || action == "-" )
            {
                result = fN - sN;
            }
            else if ( action == "m" || action == "multiply" || action == "*" )
            {
                result = fN * sN;
            }
            else if ( action == "d" || action == "divide" || action == "/" )
            {
                result = fN / sN;
            }

            return result;
        }
        static void Main(string[] args)
        {

            Console.Write("Input your first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            double sN = double.Parse(Console.ReadLine());

            Console.Write("What action would you like to perform?: ");
            string action = Console.ReadLine();

            Console.WriteLine("[Calculator] {0}", Calculator(action, fN, sN));
        }
    }
}