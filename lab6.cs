using System;

namespace lab6
{
    class Program
    {
        [Flags]
        enum Disciplines
        {
            Іноземна_мова = 0b000000001,
            Вища_математика = 0b000000010,
            Правознавство = 0b000000100,
            Основи_програмування = 0b000001000,
            Компютерна_дискретна_математика = 0b000010000,
            Інформаційні_технології_в_професійній_діяльності = 0b000100000,
            Основи_кібербезпеки = 0b001000000,
            Моделі_і_структури_даних = 0b010000000,
            Компютерна_графіка_та_візуалізація_даних = 0b100000000,
            Загальноосвітні_дисципліни = 0b000000111,
            Обовязкові_дисципліни = 0b000111000,
            Вибіркові_дисципліни = 0b111000000,
        }
        static string EnumToString(int num)
        {
            string str = "";
            var en = (Disciplines)num;
            str = en.ToString();
            str = str.Replace("_", " ");
            if (str.Contains("Комп"))
            {
                int i = str.IndexOf("Комп");
                str = str.Insert(i + 4, "'");
            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine((i + 1) + ". " + EnumToString((int)Math.Pow(2, i)));
            }

            Console.Write("\nВведіть номери дисциплін, які ви хотіли б вивчати, у вигляді списку, відокремлюючи номери комами: ");
            string input = Console.ReadLine();
            string[] array = input.Split(",");
            int[] disciplines = Array.ConvertAll(array, s => int.Parse(s));

            Console.WriteLine("\nОбрані дисципліни: ");
            Console.WriteLine("\nЗагальноосвітні дисципліни");
            for (int i = 0; i < disciplines.Length; i++)
            {
                int value = (int)Math.Pow(2, disciplines[i] - 1);   
                if ((value & 0b000000111) != 0)
                {
                    Console.WriteLine("-" + EnumToString((int)Math.Pow(2, disciplines[i] - 1)));
                }
            }

            Console.WriteLine("\nОбов'язкові дисципліни");
            for (int i = 0; i < disciplines.Length; i++)
            {
                int value = (int)Math.Pow(2, disciplines[i] - 1);
                if ((value & 0b000111000) != 0)
                {
                    Console.WriteLine("-" + EnumToString((int)Math.Pow(2, disciplines[i] - 1)));
                }
            }

            Console.WriteLine("\nВибіркові дисципліни");
            for (int i = 0; i < disciplines.Length; i++)
            {
                int value = (int)Math.Pow(2, disciplines[i] - 1);
                if ((value & 0b111000000) != 0)
                {
                    Console.WriteLine("-" + EnumToString((int)Math.Pow(2, disciplines[i] - 1)));
                }
            }

            Console.WriteLine("\nАвтор програми: Лисенко");
        }
    }
}