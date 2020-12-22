using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int totalMinutesOfExam = (hourOfExam * 60) + minuteOfExam;
            int totalMinutesOfArrival = (hourOfArrival * 60) + minuteOfArrival;

            int difference = 0;
            int hours = 0;
            int minutes = 0;

            if (totalMinutesOfExam < totalMinutesOfArrival)
            {
                difference = totalMinutesOfArrival - totalMinutesOfExam;
                minutes = difference % 60;

                if (difference >= 60)
                {
                    hours = difference / 60;
                    if (difference % 60 != 0 && difference % 60 > 9)
                    {
                        minutes = difference % 60;
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                }

                if (difference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutes} minutes after the start");

                }

            }
            if (totalMinutesOfExam >= totalMinutesOfArrival)
            {
                difference = totalMinutesOfExam - totalMinutesOfArrival;
                minutes = difference % 60;
                if (difference >= 60)
                {
                    hours = difference / 60;
                    if (difference % 60 != 0 && difference % 60 > 9)
                    {

                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                }
                else if (minutes <= 30 && minutes != 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
        }
    }
}
