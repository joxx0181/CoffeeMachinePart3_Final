using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineOCP
{
    // This class represents coffeebean and implements interfaces!
    class CoffeeBean : Ingredient, IFilter, ICup
    {
        // parametrized constructor declaration!
        public CoffeeBean (string ingName, int amount) : base(ingName, amount)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public string GetFilter()
        {
            return "inserting coffee filter.";
        }

        // 7 grams of coffeebean per.cup!
        public int GetCup()
        {
            return Amount / 7;
        }
    }
}
