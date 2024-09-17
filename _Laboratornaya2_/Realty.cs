using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Laboratornaya2_
{
    public abstract class Realty
    {
        public string NameOwner { get; set; }
        public DateTime DateCreated { get; set; }
        public int Cost { get; set; }

        Logic logic = new Logic();
        public Realty(string NameOwner, string DateCreated, string Cost)
        {
            this.NameOwner = NameOwner;
            this.DateCreated = logic.DateParse(DateCreated);
            this.Cost = logic.IntParse(Cost);
        }
        public abstract void PrintInfo();
    }
}
