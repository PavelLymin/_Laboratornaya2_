using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace _Laboratornaya2_
{
    public class Factory
    {
        public string[] getLine(string text)
        {
            return text.Trim().Split('\n');
        }

        public List<string> convertatingLine(string strings)
        {
            List<string> convetating = new List<string>();
            int firstQuoteIndex = strings.IndexOf('"');
            int lastQuoteIndex = strings.LastIndexOf('"');

            string type = strings.Substring(0, firstQuoteIndex).Trim();
            convetating.Add(type);
            string name = strings.Substring(firstQuoteIndex + 1, lastQuoteIndex - firstQuoteIndex - 1);
            convetating.Add(name);
            string[] otherPart = strings.Substring(lastQuoteIndex + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            convetating.AddRange(otherPart);

            return convetating;
        }

        public string readFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден.");
                return string.Empty;
            }
            else
                return File.ReadAllText(path);
        }

        public DateTime parseDate(string text)
        {
            if (!DateTime.TryParseExact(text, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var tempDate))
                throw new Exception("Неверный формат даты");

            return DateTime.ParseExact(text, "yyyy.MM.dd", CultureInfo.InvariantCulture);
        }

        public int parseInt(string text)
        {
            if (!int.TryParse(text, out var tempInt))
                throw new Exception("Неверный формат числа");
            return int.Parse(text);
        }

        public double parseDouble(string text)
        {
            if (!double.TryParse(text, out var tempDouble))
                throw new Exception("Неверный формат числа с плавающей точкой");
            return double.Parse(text);
        }

        public Realty createRealty(List<string> strings)
        {
            switch (strings[0]) 
            {
                case "ЧастныйЖилДом" :
                    return new PrivateResidentBuilding(strings[1], parseDate(strings[2]), parseInt(strings[3]));
                case "ДачныйДом" :
                    return new CountryHouse(strings[1], parseDate(strings[2]), parseInt(strings[3]), parseDouble(strings[4]));
                case "Новостройка":
                    return new ApartmentBuilding(strings[1], parseDate(strings[2]), parseInt(strings[3]), parseInt(strings[4]));
                default: 
                    throw new Exception("Не удалось создать экзепляр объекта");
            }
        }
    }
}
