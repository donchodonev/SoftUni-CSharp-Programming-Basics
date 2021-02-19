using System;

namespace Change_Tiles_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfPad = int.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double lengthOfTile = double.Parse(Console.ReadLine());
            int widthOfBench = int.Parse(Console.ReadLine());
            int lengthOfBench = int.Parse(Console.ReadLine());
            //calculate area
            int areaOfBench = widthOfBench * lengthOfBench;
            double areaOfTile = widthOfTile * lengthOfTile;
            int areaOfPad = (lengthOfPad * lengthOfPad) - areaOfBench;

            double timePerTileInMinutes = 0.2;

            Console.WriteLine(areaOfPad / areaOfTile);
            Console.WriteLine((areaOfPad / areaOfTile) * timePerTileInMinutes);

        }
    }
}
