using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double examCount = 0;

            do
            {
                examCount++;
                Console.WriteLine($"What is your score for exam {examCount}? please enter as a percent (e.g. 90% = 0.90) >>");
                sum += Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Do you have another score to enter? yes or no >>");

            } while (Console.ReadLine().ToLower() == "yes");

            double avg = sum / examCount;

            Console.WriteLine($"Your average is {avg.ToString("p")}");

        }
    }
}
