using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operatorT = Console.ReadLine();
            double sum = 0.00;


            if (n1 == 0 && operatorT == "/" || n2 == 0 && operatorT == "/" || n2 == 0 && operatorT == "%" || n1 == 0 && operatorT == "%")
            {
                Console.WriteLine($"Cannot divide {Math.Max(n1, n2)} by zero");
            }
            else
            {
                switch (operatorT)
                {
                    case "+":
                        sum = n1 + n2;
                        if (sum % 2 == 0)
                        {
                            Console.WriteLine($"{n1} + {n2} = {sum} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                        }
                        break;
                    case "-":
                        sum = n1 - n2;
                        if (sum % 2 == 0)
                        {
                            Console.WriteLine($"{n1} - {n2} = {sum} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} - {n2} = {sum} - odd");
                        }
                        break;
                    case "*":
                        sum = n1 * n2;
                        if (sum % 2 == 0)
                        {
                            Console.WriteLine($"{n1} * {n2} = {sum} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} * {n2} = {sum} - odd");
                        }
                        break;
                    case "/":
                        double doublen1 = Convert.ToDouble(n1);
                        double doublen2 = Convert.ToDouble(n2);
                        sum = doublen1 / doublen2;
                        Console.WriteLine($"{doublen1} / {doublen2} = {sum:F2}");
                        break;
                    case "%":
                        sum = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {sum}");
                        break;
                }
            }
        }
    }
}
