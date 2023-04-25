using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            string[] words = text.Split(" ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}