using System;
using System.IO;

namespace lab7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter file's name in given format (filename.txt): ");
            string name = Console.ReadLine();
            string path = "C:\\Users\\first\\source\\repos\\lab7\\lab7\\" + name;
            if (File.Exists(path))
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);

                    string textFromFile = System.Text.Encoding.Default.GetString(array);
                    textFromFile = textFromFile.Replace(Environment.NewLine, " ");
                    textFromFile = String.Join(" ", textFromFile.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
                    string[] numbers_string = textFromFile.Split(" ");

                    int[] numbers = Array.ConvertAll(numbers_string, s => int.Parse(s));
                    int min = numbers[0];
                    int max = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                        if (numbers[i] < min)
                        {
                            min = numbers[i];
                        }
                    }
                    Console.WriteLine("\nmin: " + min + ", max: " + max);
                }
            }
            else
            {
                Console.WriteLine("\nFile does not exist.");
            }
        }
    }
}