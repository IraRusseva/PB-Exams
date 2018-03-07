using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = begin; i <= end;  i++)
            {
                for (char j = begin; j <= end ; j++)
                {
                    for (char z = begin; z <= end; z++)
                    {
                        if (i != miss && j != miss && z != miss)
                        {
                            Console.Write($"{i}{j}{z} ");
                            counter++;

                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
