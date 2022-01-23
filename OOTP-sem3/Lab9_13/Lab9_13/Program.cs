using System;
using System.Collections.Generic;

namespace Lab9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPr.Words Words;

            ClassPr programmer = new ClassPr();
            List<string> list = new List<string> { "C#", "Ruby", "JavaScript", "Phyton", "C++", "PHP", "Java"};

            Console.Write("Начальный список: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (string item in list)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            programmer.AddLang += list =>
            {
                Console.Write("Добавление языка: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                foreach (string item in list)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            };

            programmer.ReName += list =>
            {
                Console.Write("Замена: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                foreach (string item in list)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            };

            Words = programmer.Rename;
            Words += programmer.Rename;
            Words += programmer.ADD;
            Words += programmer.ADD;
            Words(list);





            



            Func<string, string> A;
            string str = "ADS,,, , ; . sdase";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n\n\nСтрока: {str}");
            A = Str.RemovePunctuation;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.AddSymbol;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.ToUpper;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.ToLower;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.RemoveSpace;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
