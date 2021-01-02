using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int booksChecked = 0;
            string nextBook = "";

            while (nextBook != bookName)
            {
                nextBook = Console.ReadLine();
                if (nextBook == bookName)
                {
                    break;
                }
                booksChecked++;
            }

            if (nextBook == bookName)
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }
        }
    }
}
