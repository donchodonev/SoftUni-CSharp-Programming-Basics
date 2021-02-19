using System;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double wallet = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleTileSide = double.Parse(Console.ReadLine());
            double triangleTileHeight = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double mastersPrice = double.Parse(Console.ReadLine());

            double roomArea = floorLength * floorWidth;

            double oneTriangleTileArea = 0.5 * triangleTileSide * triangleTileHeight;

            double tilesNeeded = Math.Ceiling(roomArea / oneTriangleTileArea) + 5.0;

            double moneyNeeded = (tilesNeeded * pricePerTile) + mastersPrice;

            if (moneyNeeded <= wallet)
            {
                Console.WriteLine($"{wallet - moneyNeeded:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {moneyNeeded - wallet:F2} lv more.");
            }
        }
    }
}
