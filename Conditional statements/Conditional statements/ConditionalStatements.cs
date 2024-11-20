using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements
{
    internal class ConditionalStatements
    {
        //Asignment 1: VAT Calculation Method
        public static decimal CalculateVAT(string productType, decimal price)
        {
            decimal vatRate;

            switch (productType.ToLower())
            {
                case "music":
                    vatRate = 0.06m;
                    break;
                case "food":
                    vatRate = 0.12m;
                    break;
                case "alcohol":
                    vatRate = 0.25m;
                    break;
                default:
                    throw new ArgumentException("Invalid product type.");
            }
            return price * vatRate;
        }
        //Asignment 2: Gym Membership Price Calculator
        public static int CalculateGymMembershipPrice(int age, bool isPremium)
        {
            int basePrice;
            if (age < 19 || age > 64)
                basePrice = 2200;
            else
                basePrice = 3100;
            if (isPremium)
                basePrice += 300;
            return basePrice;
        }
        //Asignment 3: Calculator Method
        public static double Calculator(string operation, double num1, double num2)
        {
            switch (operation.ToLower())
            {
                case "add":
                    return num1 + num2;
                case "subtract":
                    return num1 - num2;
                case "multiply":
                    return num1 * num2;
                case "divide":
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }
        //Assignment 4: Menu Options Method
        public static void MenuOption(string option)
        {
            switch (option.ToLower())
            {
                case "help":
                    Console.WriteLine("Displaying help menu...");
                    break;
                case "add":
                    Console.WriteLine("Adding a new item...");
                    break;
                case "delete":
                    Console.WriteLine("Deleting an item...");
                    break;
                case "edit":
                    Console.WriteLine("Editing an item...");
                    break;
                case "find":
                    Console.WriteLine("Finding an item...");
                    break;
                case "list":
                    Console.WriteLine("Listing all items...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
