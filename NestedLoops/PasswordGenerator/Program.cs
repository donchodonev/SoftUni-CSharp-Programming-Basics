using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input n
            //input L
            //symbol 1 = 1 to n
            //symbol 2 = 1 to n
            //symbol 3 = lowercase letter between 1 and L
            //symbol 4 = lowercase letter between 1 and L
            //symbol 5 = digit between 1 to n, higher than symbol 1 and 2

            //ASCI 97 = 'a'

            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 97; k < 97 + L; k++)
                    {
                        for (int q = 97; q < 97 + L; q++)
                        {
                            for (int v = 1; v <= n; v++)
                            {
                                if (v > Math.Max(i,j))
                                {
                                    Console.Write(i);
                                    Console.Write(j);
                                    char sym3 = Convert.ToChar(k);
                                    Console.Write(sym3);
                                    char sym4 = Convert.ToChar(q);
                                    Console.Write(sym4);
                                    Console.Write(v + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
