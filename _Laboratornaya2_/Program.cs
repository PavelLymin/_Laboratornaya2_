﻿using System;

namespace _Laboratornaya2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Stroka = "ЧастныйЖилДом \"Федор Федоров Федорович\" 2025.09.04  25000" + '\n' +
                            "ЧастныйЖилДом \"Михаил\" 2020.05.06 32000" + '\n' +
                            "ЧастныйЖилДом \"Федор Федоров Федорович\"    2024.09.04 25000" + '\n' +
                            "ЧастныйЖилДом \"Михаил\" 2020.05.06 32000" + '\n' +
                            "ДачныйДом \"Петр Петрович\" 2020.05.06 32000 256,3" + '\n' +
                            "ДачныйДом \"Федор Федоров Федорович\"     20n50.05.06 1150 256,5" + '\n' +
                            "ДачныйДом \"Петр Павлович\" 2020.05.06     32000 256,3" + '\n' +
                            "Новостройка \"Михаил Михайлович\" 2020.05.06     5566 10" + '\n' +
                            "Новостройка     \"Петр Петрович Петров\"   2020.05.06 35l00 25" + '\n' +
                            "Новостройка \"Федор Федоров Федорович\" 2020.05.06 32000 5";

            Factory factory = new Factory();

            Console.WriteLine("Выберите откуда считать данные\n1 - текстовый файл\n2 - строка");
            string choose = Console.ReadLine();
            if (int.TryParse(choose, out var number) && (number == 1 || number == 2))
            {
                if (number == 1)
                {
                    string text = factory.readFromFile("text1.txt");
                    foreach (var line in factory.getLine(text))
                    {
                        try
                        {
                            var obj = factory.createRealty(factory.convertatingLine(line));
                            obj.printInfo();
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                else
                {
                    foreach (var line in factory.getLine(Stroka))
                    {
                        try
                        {
                            var obj = factory.createRealty(factory.convertatingLine(line));
                            obj.printInfo();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, выберите 1 или 2");
            }
        }
    }
}
