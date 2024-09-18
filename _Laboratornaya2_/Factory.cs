using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public class Factory
    {
        public string textFormatting(string Line) {
            int countQuotation = 0;
            string temp = "";
            for (int i = 0; i < Line.Length; i++) {
                if (Line[i] == '"')
                    countQuotation++;
                else if (countQuotation % 2 != 0)
                    temp += Line[i];
                else {
                    if (Line[i] == ' ')
                        temp += '_';
                    else
                        temp += Line[i];
                }
            }
            return temp;
        }

        public List<string> convertingToArray(string NewLine) {
            List<string> strings = NewLine.Split(new char[] { '_', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return strings;
        }

        public DateTime dateParse(string dateTime) {
            DateTime dateTime1 = DateTime.MinValue;
            try {
                dateTime1 = DateTime.ParseExact(dateTime, "yyyy.MM.dd", CultureInfo.InvariantCulture);
            }
            catch (Exception e) {
                e = new Exception("Строка не распознана как действительное значение DateTime. Задано по умолчанию: 01.01.0001 0:00:00");
                Console.WriteLine(e.Message);
            }
            return dateTime1;
        }

        public int intParse(string number) {
            int temp = 0;
            try {
                temp = int.Parse(number);
            }
            catch (Exception e) {
                e = new Exception("Строка не распознана как действительное значение. Задано по умолчанию: 0");
                Console.WriteLine(e.Message);
            }
            return temp;
        }

        public double doubleParse(string number) {
            double temp = 0;
            try {
                temp = double.Parse(number);
            }
            catch (Exception e) {
                e = new Exception("Строка не распознана как действительное значение с плавающей точкой. Задано по умолчанию: 0");
                Console.WriteLine(e.Message);
            }
            return temp;
        }

        public List<Realty> createRealty(List<string> strings) {
            List<Realty> realties = new List<Realty>();
            for (int i = 0; i < strings.Count; i++) {
                if (strings[i] == "ЧастныйЖилДом") {
                    PrivateResidentBuilding realty = new PrivateResidentBuilding(strings[i + 1], dateParse(strings[i + 2]), intParse(strings[i + 3]));
                    realties.Add(realty); i += 3;
                }
                else if (strings[i] == "ДачныйДом") {
                    CountryHouse realty = new CountryHouse(strings[i + 1], dateParse(strings[i + 2]), intParse(strings[i + 3]), doubleParse(strings[i + 4]));
                    realties.Add(realty); i += 4;
                }
                else if (strings[i] == "Новостройка") {
                    ApartmentBuilding realty = new ApartmentBuilding(strings[i + 1], dateParse(strings[i + 2]), intParse(strings[i + 3]), intParse(strings[i + 4]));
                    realties.Add(realty); i += 4;
                }
            }
            return realties;
        }
    }
}
