using System;

class Program
{

    public static void Main(string[] args)
    {
        string answer = "no";
        do
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            string input = Console.ReadLine();
            double num1 = double.Parse(input);
            double a = num1 * 2;
            double b = num1 * 2;
            double c = num1 * 4;
            Console.WriteLine();
            Console.WriteLine("You need:");
            Console.WriteLine();
            Console.WriteLine(a + " slices of bread");
            Console.WriteLine(b + " tablespoons of peanut butter");
            Console.WriteLine(c + " tablespoons of jelly");
            Console.WriteLine();
            Console.WriteLine("Which is...");
            double d = Math.Ceiling(a / 28);
            double e = Math.Ceiling(b / 32);
            double f = Math.Ceiling(c / 48);
            Console.WriteLine();
            Console.WriteLine(d + " loaves of bread");
            Console.WriteLine(e + " jars of peanut butter");
            Console.WriteLine(f + " jars of jelly");
            Console.WriteLine();
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            answer = Console.ReadLine();
            Console.WriteLine();
        } while (answer == "yes" || answer == "y");
        Console.WriteLine("Goodbye!");
    }
}