using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examStartingHour = int.Parse(Console.ReadLine());
            int examStartingMinutes = int.Parse(Console.ReadLine());
            int studentArrivalHour = int.Parse(Console.ReadLine());
            int studentArrivalMinutes = int.Parse(Console.ReadLine());

            //convert time to minutes

            int examTime = (examStartingHour * 60) + examStartingMinutes;
            int studentArrivalTime = (studentArrivalHour * 60) + studentArrivalMinutes;

            int minutesDifference = studentArrivalTime - examTime;

            //check if student is dead on time
            if (minutesDifference == 0)
            {
                Console.WriteLine("On time");
            }
            // check if student came within 30 minutes before staring the exam
            else if (minutesDifference >= -30 && minutesDifference < 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Abs(minutesDifference)} minutes before the start");
            }
            // check if student is late
            else if (minutesDifference > 0)
            {
                Console.WriteLine("Late");
                if (minutesDifference >= 60)
                {
                    Console.Write($"{minutesDifference / 60}");
                    if (minutesDifference % 60 < 10)
                    {
                        Console.Write($":0{minutesDifference % 60} hours after the start");
                    }
                    else
                    {
                        Console.Write($":{minutesDifference % 60} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
            }
            // check if student is early and re-use print code with Math.Abs to remove the "-" sign
            else if (minutesDifference < 0)
            {
                Console.WriteLine("Early");
                if (Math.Abs(minutesDifference) >= 60)
                {
                    Console.Write($"{Math.Abs(minutesDifference) / 60}");
                    if (Math.Abs(minutesDifference) % 60 < 10)
                    {
                        Console.Write($":0{Math.Abs(minutesDifference % 60)} hours before the start");
                    }
                    else
                    {
                        Console.Write($":{Math.Abs(minutesDifference % 60)} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(minutesDifference)} minutes before the start");
                }
            }
        }
    }
}
