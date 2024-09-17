using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Stroka = "ЧастныйЖилДом \"Федор Федоров Федорович\" 2025.09.04 25000" + '\n' +
                "ЧастныйЖилДом \"Михаил\" 2020.05.06 32000" + '\n' +
                "ЧастныйЖилДом \"Федор Федоров Федорович\" 2024.09.04 25000" + '\n' +
                "ЧастныйЖилДом \"Михаил\" 2020.05.06 32000" + '\n' +
                "ДачныйДом \"Петр Петрович\" 2020.05.06 32000 256,3" + '\n' +
                "ДачныйДом \"Федор Федоров Федорович\" 2020.05.06 32000 256,5" + '\n' +
                "ДачныйДом \"Петр Павлович\" 2020.05.06 32000 256,3" + '\n' +
                "Новостройка \"Михаил Михайлович\" 2020.05.06 32000 10" + '\n' +
                "Новостройка \"Петр Петрович Петров\" 2020.05.06 32000 25" + '\n' +
                "Новостройка \"Федор Федоров Федорович\" 2020.05.06 32000 5";

            Logic logic = new Logic();
            foreach (var realty in logic.GetListOfTypes(logic.ConvertingToArray(logic.TextFormatting(Stroka))))
            {
                realty.PrintInfo();
            }
        }
    }
}
