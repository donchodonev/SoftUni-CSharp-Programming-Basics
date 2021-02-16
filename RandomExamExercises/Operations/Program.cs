using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            string sign = Console.ReadLine();

            decimal result = 0m;
            //if var y == 0 - stop
            if (y == 0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine($"Cannot divide {x} by zero");
                return;
            }
            //check sign and proceed with calculation of the result
            switch (sign)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                case "%":
                    result = x % y;
                    break;
            }

            if (sign == "+" || sign == "-" || sign == "*")
            {
                //check if num is even or odd
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{x} {sign} {y} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{x} {sign} {y} = {result} - odd");
                }
            }
            else if (sign == "/")
            {
                Console.WriteLine($"{x} {sign} {y} = {result:F2}");
            }
            else if (sign == "%")
            {
                Console.WriteLine($"{x} {sign} {y} = {result}");
            }
        }
    }
}
