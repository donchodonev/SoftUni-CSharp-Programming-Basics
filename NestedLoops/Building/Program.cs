using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());
            int topFloor = floorCount;



            if (topFloor == floorCount)
            {
                int roomsPrinted = 0;
                while (roomCount > 0)
                {
                    Console.Write($"L{floorCount}{roomsPrinted} ");
                    roomsPrinted++;
                    roomCount--;
                }
                topFloor--;
                roomCount += roomsPrinted;
                Console.WriteLine();
            }
            //decreasing total floor count by 1 to keep the logic intact as actions for it were done already
            floorCount--;

            while (floorCount >= 1)
            {
                if (floorCount % 2 != 0)
                {
                    int roomsPrinted = 0;
                    while (roomCount > 0)
                    {
                        Console.Write($"A{floorCount}{roomsPrinted} ");
                        roomsPrinted++;
                        roomCount--;
                    }

                    roomCount += roomsPrinted;
                    Console.WriteLine();
                }
                else
                {
                    int roomsPrinted = 0;
                    while (roomCount > 0)
                    {
                        Console.Write($"O{floorCount}{roomsPrinted} ");
                        roomsPrinted++;
                        roomCount--;
                    }

                    roomCount += roomsPrinted;
                    Console.WriteLine();

                }
                floorCount--;
            }
        }
    }
}
