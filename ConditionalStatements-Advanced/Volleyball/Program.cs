using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year_type = Console.ReadLine();
            int totalWeekends = 48;
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            double playingInSofia = (totalWeekends - weekendsHome) * (3.0 / 4.0);
            double holidaysPlaying = holidays * (2.0 / 3.0);

            double totalTimePlayed = playingInSofia + weekendsHome + holidaysPlaying;

            if (year_type == "leap")
            {
                totalTimePlayed = (totalTimePlayed / 100) * 115;
                Console.WriteLine($"{Math.Floor(totalTimePlayed)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(totalTimePlayed)}");
            }
        }
    }
}
