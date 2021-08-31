using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            double y = LineValueForY(1, 7, 0);
            Console.WriteLine($"y = (1)*7 + 0 ==> {y.ToString("n")}");

            double fact = Factorial(5);
            Console.WriteLine($"5! ==> {fact.ToString("N0")}");

            Console.WriteLine("Please enter a number to calculate the factorial of >>");
            Console.WriteLine($"{Factorial(Convert.ToInt32(Console.ReadLine()))}");
        }

        /// <summary>
        /// Calculate the y value of a line
        /// </summary>
        /// <param name="m">The slope of the line</param>
        /// <param name="x">The x value of the line</param>
        /// <param name="b">The y intercept of the line</param>
        /// <returns></returns>
        static double LineValueForY(double m, double x, double b)
        {
            double answer = 0;

            answer = m * x + b;

            return answer;
        }

        /// <summary>
        /// Calculate the factorial value of a number
        /// </summary>
        /// <param name="number">The number to calculate the factorial of</param>
        /// <returns>The factorial result</returns>
        static int Factorial(int number)
        {
            int value = 1;

            for (int i = number; i > 0; i--)
            {
                value = value * i;
                //value *= i;
            }

            return value;
        }
    }
}
