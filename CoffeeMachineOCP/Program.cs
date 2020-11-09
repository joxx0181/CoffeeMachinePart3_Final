using System;

namespace CoffeeMachineOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient water = new Water("water", 1);

            CoffeeBean coffee = new CoffeeBean("coffee", 42);
            The the = new The("the", 12);
            EspressoBean espresso = new EspressoBean("espresso", 42);

            int res1 = 0;
            string res2 = " ";
            string res3 = " ";
            int res4 = 0;
            string res5 = " ";
            int res6 = 0;

            Console.WriteLine("what to do... : \n1) boil water \n2) Make coffee \n3) Make the \n4) Make espresso");
            string userChoice = Console.ReadLine();

            {
                switch (userChoice)
                {
                    case "1":
                        res1 = water.Amount;
                        res2 = water.INGName;
                        res3 = "no filter has been insert";
                        res5 = "nothing";
                        break;
                    case "2":
                        res1 = water.Amount;
                        res2 = water.INGName;
                        res3 = coffee.GetFilter();
                        res4 = coffee.Amount;
                        res5 = coffee.INGName;
                        res6 = coffee.GetCup();
                        break;
                    case "3":
                        res1 = water.Amount;
                        res2 = water.INGName;
                        res3 = the.GetFilter();
                        res4 = the.Amount;
                        res5 = the.INGName;
                        res6 = the.GetCup();
                        break;
                    case "4":
                        res1 = water.Amount;
                        res2 = water.INGName;
                        res3 = espresso.GetFilter();
                        res4 = espresso.Amount;
                        res5 = espresso.INGName;
                        res6 = espresso.GetCup();
                        break;
                    default:
                        Console.WriteLine("UPS...something went wrong");
                        break;
                }
            }
            Console.WriteLine("\nPour " + res1 + " liter of " + res2 + " on the cointainer.");
            Console.WriteLine(res3 + "\nPour " + res4 + " gram of " + res5 + " on the machine." + "\n\n.............Starting..............");
           
            if (userChoice != "1") 
            { 
                Console.WriteLine("the machine has made " + res6 + " cups of " + res5); 
            } else 
            {
                Console.WriteLine("the machine has made " + res1 + " ltr. boil water.");
            }

            Console.ReadLine();
        }
    }
}
