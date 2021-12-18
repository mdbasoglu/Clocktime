using System;

namespace Uebung54_Clocktime_Musterlösung
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Clocktime ct = new Clocktime(8, 10, 40);
            Console.WriteLine(ct.Hours);
            Console.WriteLine(ct.Minutes);
            Console.WriteLine(ct.Seconds);

            Console.WriteLine(ct);

            Clocktime c1 = new Clocktime().Add(5);
            Console.WriteLine(c1);

            Clocktime c2 = new Clocktime(1, 7, -101).Add(-8000);
            Console.WriteLine(c2);

            Console.WriteLine(c1.Diff(c2));
            Console.WriteLine(c2.Diff(c1));



            Clocktime test = new Clocktime(-1, -5, 0);
            Console.WriteLine(test);


        }
    }
}
