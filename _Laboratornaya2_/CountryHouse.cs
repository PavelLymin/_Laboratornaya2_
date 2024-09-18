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

        public CountryHouse(string NameOwner, DateTime DateCreated, int Cost, double LandPlotArea)
            : base(NameOwner, DateCreated, Cost)
        {
            this.LandPlotArea = LandPlotArea;
        }

        public override void printInfo()
        {
            Console.WriteLine($"{NameOwner} {DateCreated} {Cost} {LandPlotArea}");
        }
    }
}
