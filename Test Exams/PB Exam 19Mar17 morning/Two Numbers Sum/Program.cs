using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int number = 0;
            int sum = 0;

            for (int i = startingNumber; i >= endingNumber ; i--)
            {
                for (int j = startingNumber; j >= endingNumber; j--)
                {
                    number += 1;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{number} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{number} combinations - neither equals {magicNumber}");
        }
    }
}
