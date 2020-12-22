using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {

            double currRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double metersPerSecond = double.Parse(Console.ReadLine());
            double secondsAddedDueToR = Math.Floor((distanceInMeters / 15)) * 12.5;
            double ivanchoTime = (distanceInMeters * metersPerSecond) + secondsAddedDueToR;

            if (currRecordInSeconds <= ivanchoTime)
            {
                Console.WriteLine($"No, he failed! He was {ivanchoTime - currRecordInSeconds:f2} seconds slower.");
            }

            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");
            }
        }
    }
}
