using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int cut = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.WriteLine("<{0}-{1}>", i, j);
                    count++;
                    if(count == cut)
                    {
                        return;
                    }
                }
            }
        }
    }
}
