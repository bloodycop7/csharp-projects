namespace Task11
{
    internal class Program
    {
        // Напишете програма, която приема възраст от потребителя и извежда дали той/тя е пълнолетен/непълнолетен.
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            int age = int.Parse(Console.ReadLine());

            if ( age < 18 )
            {
                Console.WriteLine("You are not an adult, please don't smoke, consume drugs or anything that may cause major health issues.");
            }
            else
            {
                Console.WriteLine("You can do whatever you want honestly.");
            }
        }
    }
}