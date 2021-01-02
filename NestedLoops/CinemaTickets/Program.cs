using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //tickets
            double totalOverallTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidsTickets = 0;
            //movie name
            string movie = "";
            //movie checking ended or not
            bool movieCheckEnd = true;
            //ticket purchase ended

            while (movieCheckEnd)
            {
                //total tickets per movie
                int totalTicketsPerMovie = 0;
                //how full the theatre is
                double percentFull = 0.00;
                //max total seats
                double maxSeats = 0.00;
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    movieCheckEnd = false;
                    break;
                }
                bool ticketPurchaseCheckEnd = true;
                maxSeats = double.Parse(Console.ReadLine());//check max possible ticket sales 
                while (totalTicketsPerMovie < maxSeats && ticketPurchaseCheckEnd)
                {
                    string ticket = Console.ReadLine();
                    if (ticket == "End")
                    {
                        ticketPurchaseCheckEnd = false;
                        break;
                    }
                    //ticket type check
                    switch (ticket)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidsTickets++;
                            break;
                    }
                    //increment total overall ticket number by 1 after each ticket type increment
                    totalOverallTickets++;
                    totalTicketsPerMovie++;
                }

                //check how full the theatre is
                percentFull = (totalTicketsPerMovie / maxSeats) * 100.00;
                //print movie name and theatre used capacity in %
                Console.WriteLine($"{movie} - {percentFull:F2}% full.");

            }
            //print total tickets sold
            Console.WriteLine($"Total tickets: {totalOverallTickets}");
            //print percentage of student tickets
            Console.WriteLine($"{(studentTickets / totalOverallTickets) * 100:F2}% student tickets.");
            //print percentage of standard tickets
            Console.WriteLine($"{(standardTickets / totalOverallTickets) * 100:F2}% standard tickets.");
            //print percentage of kids tickets
            Console.WriteLine($"{(kidsTickets / totalOverallTickets) * 100:F2}% kids tickets.");
        }
    }
}
