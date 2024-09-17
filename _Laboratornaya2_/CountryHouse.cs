using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public class CountryHouse : Realty
    {
        public double LandPlotArea { get; set; }

        Logic logic = new Logic();
        public CountryHouse(string NameOwner, string DateCreated, string Cost, string LandPlotArea)
            : base(NameOwner, DateCreated, Cost)
        {
            this.LandPlotArea = logic.DoubleParse(LandPlotArea);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOwner} {DateCreated} {Cost} {LandPlotArea}");
        }
    }
}
