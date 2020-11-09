using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineOCP
{
    // This class represents espresso and implements interfaces!
    class EspressoBean : Ingredient, IFilter, ICup
    {
        // parametrized constructor declaration!
        public EspressoBean (string ingName, int amount) : base(ingName, amount)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public string GetFilter()
        {
            return "inserting espresso filter.";
        }

        // 7 grams of coffeebean per.cup!
        public int GetCup()
        {
            return (Amount / 14) / 3;
        }
    }
}
