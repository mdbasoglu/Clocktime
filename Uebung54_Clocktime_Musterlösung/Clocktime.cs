using System;
namespace Uebung54_Clocktime_Musterlösung
{
    class Clocktime
    {
        private int totalSeconds;
        private const int SecondsADay = 86400;


        public int Hours { get => totalSeconds / 3600; }
        public int Minutes { get => totalSeconds / 60 % 60; }
        public int Seconds { get => totalSeconds % 60; }


        public Clocktime(int h, int m, int s)
        {
            totalSeconds = h * 3600 + m * 60 + s;
            NormalizeClocktime();
        }

        private void NormalizeClocktime()
        {
            totalSeconds %= SecondsADay;

            if (totalSeconds < 0)
            {
                totalSeconds += SecondsADay;
            }
        }

        public Clocktime(int h, int m) : this(h, m, 0)
        {

        }

        public Clocktime(int h) : this(h, 0, 0)
        {

        }

        public Clocktime() : this(0, 0, 0)
        {
            //oder können wir anstatt this totalSeconds=0; nutzen
        }

        public Clocktime(Clocktime ct) //Copy Konstruktor
        {
            totalSeconds = ct.totalSeconds;
        }

        public Clocktime Add(int s)
        {
            totalSeconds = totalSeconds + s;
            NormalizeClocktime();

            return this;

        }

        public int Diff(Clocktime ct)
        {
            int diffsec = ct.totalSeconds - totalSeconds;

            if (diffsec < 0)
            {
                diffsec += SecondsADay;
            }

            return diffsec;
        }

        public override string ToString()
        {
            //hh:mm:ss
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }




    }
}
