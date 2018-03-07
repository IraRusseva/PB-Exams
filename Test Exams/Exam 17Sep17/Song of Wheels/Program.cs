using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_of_Wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkDigit = int.Parse(Console.ReadLine());
            int password = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                if (checkDigit == a*b + c*d)
                                {
                                    Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                    password++;
                                    if (password == 4)
                                    {
                                        password = $"{a}{b}{c}{d}";
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
