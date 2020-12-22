using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
