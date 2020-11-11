using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineOCP
{
    // This class represents water!
    class Water : Ingredient
    {
        // parametrized constructor declaration!
        public Water (string ingName, int amount) : base(ingName, amount)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
