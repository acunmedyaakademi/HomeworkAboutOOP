namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker wrk1 = new Worker("Ayşe" );
            Worker wrk2 = new Worker("Aylin" );

            Console.WriteLine(wrk1.Name);
            wrk1.DailyWorkingHours = 7;


            Console.WriteLine(wrk2.Name);
            wrk2.DailyWorkingHours = 9;


           

            Console.ReadLine();
        }

    }
}

