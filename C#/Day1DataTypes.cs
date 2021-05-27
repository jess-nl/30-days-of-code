using System;

namespace Day1DataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;

            // Read and save an integer, double, and String to your variables.

            i2 = int.Parse(Console.ReadLine()); // or you can do (int)Convert.ToInt64()
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Convert.ToString(Console.ReadLine());

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:F1}", d + d2);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);

            // Note the decimal places: 4.0 4.00 4.00 4.000
            //Console.WriteLine("{0:F1} {0:F} {0:F2} {0:F3}", d);
        }
    }
}
