using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineOCP
{
    // This class represents The and implements interfaces!
    class The : Ingredient, IFilter, ICup
    {
        // parametrized constructor declaration!
        public The (string ingName, int amount) : base(ingName, amount)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public string GetFilter()
        {
            return "inserting the filter.";
        }

        // 3 grams of the per.cup!
        public int GetCup()
        {
            return Amount / 3;
        }
    }
}
