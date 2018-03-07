using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = int.Parse(Console.ReadLine());

            double points = 0;
            double numbersToNine = 0;
            double numbersToNineteen = 0;
            double numbersTotwentyNine = 0;
            double numbersToThirtyNine = 0;
            double numbersToFifty = 0;
            double invalidNumbers = 0;
            //double allNumbers = 0;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    points += number * 0.20;
                    numbersToNine +=1;
                }
                else if (number >= 10 && number <= 19)
                {
                    points += number * 0.30;
                    numbersToNineteen +=1;
                }
                else if (number > 19 && number <= 29)
                {
                    points += number * 0.40;
                    numbersTotwentyNine +=1;
                }
                else if (number > 29 && number <= 39)
                {
                    points += 50;
                    numbersToThirtyNine +=1;
                }
                else if (number > 39 && number <= 50)
                {
                    points += 100;
                    numbersToFifty += 1;
                }
                else
                {
                    points /= 2;
                    invalidNumbers +=1;
                }
               // allNumbers += number;
            }
            double percentToNine = (numbersToNine / moves) * 100;
            double percentToNineteen = (numbersToNineteen / moves) * 100;
            double percentToTwentyNine = (numbersTotwentyNine / moves) * 100;
            double percentToThirtyNine = (numbersToThirtyNine / moves) * 100;
            double percentToFifty = (numbersToFifty / moves) * 100;
            double percentInvalid = (invalidNumbers / moves) * 100;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {percentToNine:f2}%");
            Console.WriteLine($"From 10 to 19: {percentToNineteen:f2}%");
            Console.WriteLine($"From 20 to 29: {percentToTwentyNine:f2}%");
            Console.WriteLine($"From 30 to 39: {percentToThirtyNine:f2}%");
            Console.WriteLine($"From 40 to 50: {percentToFifty:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");
        }
    }
}
