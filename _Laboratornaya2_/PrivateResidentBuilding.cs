﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public class PrivateResidentBuilding : Realty
    {
        public PrivateResidentBuilding(string NameOwner, string DateCreated, string Cost)
            : base(NameOwner, DateCreated, Cost) { }

        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOwner} {DateCreated} {Cost}");
        }
    }
}
