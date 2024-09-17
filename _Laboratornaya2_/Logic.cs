using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public class Logic
    {
        public string TextFormatting(string Line)
        {
            int countQuotation = 0;
            string temp = "";
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line[i] == '"')
                    countQuotation++;
                else if (countQuotation % 2 != 0)
                    temp += Line[i];
                else
                {
                    if (Line[i] == ' ')
                        temp += '_';
                    else
                        temp += Line[i];
                }
            }
            return temp;
        }

        public List<string> ConvertingToArray(string NewLine)
        {
            List<string> strings = NewLine.Split(new char[] { '_', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return strings;
        }

        public List<Realty> GetListOfTypes(List<string> strings)
        {
            List<Realty> realties = new List<Realty>();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i] == "ЧастныйЖилДом")
                {
                    PrivateResidentBuilding realty = new PrivateResidentBuilding(strings[i + 1], DateTime.ParseExact(strings[i + 2], "yyyy.MM.dd", CultureInfo.InvariantCulture), Convert.ToInt32(strings[i + 3]));
                    realties.Add(realty); i += 3;
                }
                else if (strings[i] == "ДачныйДом")
                {
                    CountryHouse realty = new CountryHouse(strings[i + 1], DateTime.ParseExact(strings[i + 2], "yyyy.MM.dd", CultureInfo.InvariantCulture), int.Parse(strings[i + 3]), Convert.ToDouble(strings[i + 4]));
                    realties.Add(realty); i += 4;
                }
                else if (strings[i] == "Новостройка")
                {
                    ApartmentBuilding realty = new ApartmentBuilding(strings[i + 1], DateTime.ParseExact(strings[i + 2], "yyyy.MM.dd", CultureInfo.InvariantCulture), int.Parse(strings[i + 3]), int.Parse(strings[i + 4]));
                    realties.Add(realty); i += 4;
                }
            }
            return realties;
        }
    }
}
