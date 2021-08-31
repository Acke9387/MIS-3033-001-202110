using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            fruits[0] = "Apples";
            fruits[1] = "Oranges";
            fruits[2] = "Bananas";
            fruits[3] = "Grapes";
            fruits[4] = "Blueberries";

            double[] prices = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            Console.WriteLine("Please enter a fruit to look up the price of >>");
            string fruit = Console.ReadLine();

            int indexOfFruit = -1;

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruit == fruits[i])
                {
                    indexOfFruit = i;
                    break;
                }

            }

            string newFruit = CapitalizeFirstLetter(fruit);

            if (indexOfFruit >= 0)
            {
                Console.WriteLine($"{fruit}'s cost {prices[indexOfFruit].ToString("C")}");
            }
            else
            {
                Console.WriteLine($"We do not carry {fruit} here! Begone.");
            }

        }

        static void AlternateWay()
        {
            string[] fruits = new string[5];
            fruits[0] = "Apples";
            fruits[1] = "Oranges";
            fruits[2] = "Bananas";
            fruits[3] = "Grapes";
            fruits[4] = "Blueberries";

            double[] prices = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            Console.WriteLine("Please enter a fruit to look up the price of >>");
            string fruit = Console.ReadLine();

            
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruit == fruits[i])
                {
                    Console.WriteLine($"{fruit}'s cost {prices[i].ToString("C")}");
                    return;
                    //break;
                }

            }
            Console.WriteLine($"We do not carry {fruit} here! Begone.");

        }


        static string CapitalizeFirstLetter(string word)
        {
            string result = word.ToUpper()[0] + word.ToLower().Substring(1);

            return result;
        }
    }
}
