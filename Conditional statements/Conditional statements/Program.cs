using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: VAT Calculation
            Console.WriteLine("VAT (music, 100): " + ConditionalStatements.CalculateVAT("music", 100));
            Console.WriteLine("VAT (food, 100): " + ConditionalStatements.CalculateVAT("food", 100));
            Console.WriteLine("VAT (alcohol, 100): " + ConditionalStatements.CalculateVAT("alcohol", 100));

            //Assignment 2: Gym Membership
            Console.WriteLine("Gym (age 15, standard): " + ConditionalStatements.CalculateGymMembershipPrice(15, false));
            Console.WriteLine("Gym (age 25, premium): " + ConditionalStatements.CalculateGymMembershipPrice(25, true));
            Console.WriteLine("Gym (age 45, standard): " + ConditionalStatements.CalculateGymMembershipPrice(45, false));
            Console.WriteLine("Gym (age 65, premium): " + ConditionalStatements.CalculateGymMembershipPrice(65, true));

            //Assignment 3: Calculator
            Console.WriteLine("Calculator (add 1 + 2): " + ConditionalStatements.Calculator("add", 1, 2));
            Console.WriteLine("Calculator (subtract 4 - 3): " + ConditionalStatements.Calculator("subtract", 4, 3));
            Console.WriteLine("Calculator (multiply 5 * 6): " + ConditionalStatements.Calculator("multiply", 5, 6));
            Console.WriteLine("Calculator (divide 8 / 2): " + ConditionalStatements.Calculator("divide", 8, 2));

            //Assignment 4: Menu Option
            Console.WriteLine("Menu Option Test:");
            ConditionalStatements.MenuOption("help");
            ConditionalStatements.MenuOption("add");
            ConditionalStatements.MenuOption("delete");
            ConditionalStatements.MenuOption("edit");
            ConditionalStatements.MenuOption("find");
            ConditionalStatements.MenuOption("list");
            ConditionalStatements.MenuOption("invalid");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
