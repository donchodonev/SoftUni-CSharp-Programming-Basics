using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit_sum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double yearly_interest_rate = double.Parse(Console.ReadLine()) / 100;

            double sum = deposit_sum + period * ((deposit_sum * yearly_interest_rate) / 12);


            Console.WriteLine(sum);
        }
    }
}
