using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int ctrlNumber = int.Parse(Console.ReadLine());

            int moves = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {

                for (int ji = m; ji >= 1; ji--)
                {
                    if (sum >= ctrlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {ctrlNumber}");
                        return;
                    }

                    moves++;

                        sum += i * 2 + ji * 3;
                }
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
