using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineOCP
{
    // This class represents ingredient!
    public abstract class Ingredient
    {
        // parametrized constructor declaration!
        public Ingredient(string ingName, int amount)
        {
            // initialization!
            INGName = ingName;
            Amount = amount;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public string INGName { get; set; }
        public int Amount { get; set; }

        // formatting method - it converts an object to its string representation so that it is suitable for display!
        public override string ToString()
        {
            return "type: " + INGName + "\ncup: " + Amount;
        }
    }
}
