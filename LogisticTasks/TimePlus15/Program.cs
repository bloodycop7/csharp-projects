namespace TimePlus15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            if ( (minute + 15 ) > 59 )
            {
                hour++;
                minute = ( 60 - ( minute + -15 ));
            }

            if ( hour == 24 )
            {
                hour = 0;
            }

            Console.WriteLine(String.Format("{00:00}", hour) + ":" + String.Format("{00:00}", minute));
        }
    }
}