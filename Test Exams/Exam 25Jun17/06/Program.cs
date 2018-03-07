using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = int.Parse(Console.ReadLine());

            int sum = 0;
            int multiplication = 0;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c && a + b + c == ctrl)
                        {
                            sum = a + b + c;
                            Console.WriteLine($"{a} + {b} + {c} = {ctrl}");
                        }
                        if (a > b && b > c && a * b * c == ctrl)
                        {
                            multiplication = a * b * c;
                            Console.WriteLine($"{a} * {b} * {c} = {ctrl}");
                        }

                    }
                }
            }
            if (sum != 0)
            {
                Console.WriteLine();
            }
            if (multiplication != 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No!");
            }
            
        }
    }
}
