using System;

namespace _Laboratornaya2_
{
    public class ApartmentBuilding : Realty
    {
        public int Floor { get; set; }

        public ApartmentBuilding(string NameOwner, DateTime DateCreated, int Cost, int Floor)
            : base(NameOwner, DateCreated, Cost)
        {
            this.Floor = Floor;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Owner: {NameOwner}, Date: {DateCreated:dd.MM.yyyy}, Cost: {Cost}, Floor: {Floor}");
        }
    }
}
