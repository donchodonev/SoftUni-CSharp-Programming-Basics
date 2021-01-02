using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string i = Console.ReadLine();
                if (i != "Stop")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    break;
                }
            }
    }
}
