using System;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {

            //hor - horizontal axis
            //ver - vertical axis

            int topLeftCornerVer = int.Parse(Console.ReadLine()); //x1
            int topRightCornerHor = int.Parse(Console.ReadLine());//y1
            int bottomRightCornerVer = int.Parse(Console.ReadLine());//x2
            int bottomRightCornerHor = int.Parse(Console.ReadLine());//y2
            int xVer = int.Parse(Console.ReadLine());//x
            int yHor = int.Parse(Console.ReadLine());//y

            //check if point is on rectangle's vertical sides
            bool isOnLeftSide = (xVer == topLeftCornerVer) && (yHor >= topRightCornerHor) && (yHor <= bottomRightCornerHor);
            bool isOnRightSide = (xVer == bottomRightCornerVer) && (yHor >= topRightCornerHor) && (yHor <= bottomRightCornerHor);
            //check if point is on rectangle's horizontal sides
            bool isOnTopSide = (yHor == topRightCornerHor) && (xVer >= topLeftCornerVer) && (xVer <= bottomRightCornerVer);
            bool isOnBottomSide = (yHor == bottomRightCornerHor) && (xVer >= topLeftCornerVer) && (xVer <= bottomRightCornerVer);

            if (isOnLeftSide || isOnRightSide || isOnTopSide || isOnBottomSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
