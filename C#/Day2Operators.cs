using System;

namespace Day1_DataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double meal_cost = 12.00;
            int tip_percent = 20;
            int tax_percent = 8;

            double tip_cost;
            tip_cost = meal_cost * tip_percent / 100;

            double tax_cost;
            tax_cost = (meal_cost * tax_percent) / 100;

            double total;
            total = meal_cost + tip_cost + tax_cost;

            int roundTotal = (int)Math.Round(total);
            Console.WriteLine(roundTotal);
        }
    }
}
