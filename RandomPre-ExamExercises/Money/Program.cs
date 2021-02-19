using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinCount = int.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double exchangeComission = double.Parse(Console.ReadLine());

            double eur = 1.95;
            double usd = 1.76;

            double bitcoinLv = bitcoinCount * 1168;
            double totalMoneyFromCHY = (chineseYuan * 0.15) * usd; //1 chinese yuan == 0.15 USD

            double balance = (bitcoinLv + totalMoneyFromCHY) - (((bitcoinLv + totalMoneyFromCHY) / 100) * exchangeComission);

            Console.WriteLine(balance / eur);

        }
    }
}
