using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public class ApartmentBuilding : Realty
    {
        public int Floor { get; set; }

        Logic logic = new Logic();
        public ApartmentBuilding(string NameOwner, string DateCreated, string Cost, string Floor)
            : base(NameOwner, DateCreated, Cost)
        {
            this.Floor = logic.IntParse(Floor);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOwner} {DateCreated} {Cost} {Floor}");
        }
    }
}
