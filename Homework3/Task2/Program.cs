namespace Task2
{
    internal class Program
    {

        // Създайте програма, която изисква потребителят да въведе своето име и след това извежда поздравно съобщение с името му.

        static void Main(string[] args)
        {
            string[] greetMessages = {
                "Hello {0}, nice to see you again", 
                "Welcome back {0}, nice to know you didn't quit on your first day.",
                "Ah, hello there {0}. Hope you're having a good morning."
            };

            Random random = new Random();

            int randomNum = random.Next(0, (greetMessages.Length - 1));

            Console.Write("What is your first name?: ");
            string fName = Console.ReadLine();

            Console.WriteLine(greetMessages[randomNum], fName);
        }
    }
}