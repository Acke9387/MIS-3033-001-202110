using System;

namespace Conditionals
{
    class Program
    {
        const double WHOLESALE_COG_PRICE = 79.99;
        const double WHOLESALE_GEAR_PRICE = 250.00;
        const double MARKUP_FULL = 0.15;
        const double MARKUP_DISCOUNT = 0.125;
        const double SALES_TAX = 0.089;

        static void Main(string[] args)
        {
            string answer;
            int cogs, gears;
            Console.WriteLine("How many cogs are you wanting to order? >>");
            answer = Console.ReadLine();

            if (int.TryParse(answer, out cogs) == false)
            {
                Console.WriteLine("Unexpected input for cogs.  Goodbye");
                Environment.Exit(-5);
            }
            
            Console.WriteLine("How many gears are you wanting to order? >>");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out gears) == false)
            {
                Console.WriteLine("Unexpected input for gears.  Goodbye");
                Environment.Exit(-6);
            }

            double markup;

            //&& = AND operator
            //|| = OR operator
            if (cogs >= 10 || gears >= 10 || (cogs + gears) >= 16)
            {
                markup = MARKUP_DISCOUNT;
            }
            else
            {
                markup = MARKUP_FULL;
            }

            double cogPrice = WHOLESALE_COG_PRICE * (1+markup);
            double cogMaxPrice = WHOLESALE_COG_PRICE * (1 + MARKUP_FULL);

            double gearPrice = WHOLESALE_GEAR_PRICE * (1 + markup);
            double gearMaxPrice = WHOLESALE_GEAR_PRICE * (1 + MARKUP_FULL);

            double totalCog = cogPrice * cogs;
            double totalMaxCog = cogs * cogMaxPrice;

            double totalGear = gearPrice * gears;
            double totalMaxGear = gears * gearMaxPrice;
            

            double total = totalCog + totalGear;
            double totalMax = totalMaxCog + totalMaxGear;

            double tax = total * SALES_TAX;
            total += tax;
            //total = total + tax;
            totalMax += totalMax * SALES_TAX;
            // totalmax = totalmax + totalmax*sales_TAX

            Console.WriteLine($"Cogs @ {cogPrice.ToString("C")} x {cogs.ToString("N0")} = {totalCog.ToString("C")}");
            Console.WriteLine($"Gears @ {gearPrice.ToString("C")} x {gears.ToString("N0")} = {totalGear.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Salex Tax: \t{tax.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Total: \t{total.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Discount: \t{(totalMax-total).ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
