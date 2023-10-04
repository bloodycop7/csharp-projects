namespace Calculator
{
    internal class Program
    {
        static int Calculate(string action, int num1, int num2)
        {
            int result = 0;

            if (action == "add")
            {
                result = num1 + num2;
            }
            else if (action == "take")
            {
                result = num1 - num2;
            }
            else if (action == "multiply")
            {
                result = num1 * num2;
            }
            else if (action == "divide")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Action");

                return -1;
            }
                
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("What would you like to do? (add, take, multiply, divide):");
            string actionInput = Console.ReadLine();

            Console.Write("Input your first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int returnValue = Calculate(actionInput, num1, num2);

            Console.WriteLine("Output: " + returnValue);
        }
    }
}