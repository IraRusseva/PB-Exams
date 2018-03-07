using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_generator
{
    class Program
    {
        static void Main(string[] args)

        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());


            for (int i = m; i >= 1; i--)
            {


                for (int x = n; x >= 1; x--)
                {
                    for (int j = l; j >= 1; j--)
                    {
                        int number = (i * 100) + (x * 10) + j;
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);

                            return;
                        }


                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                    }
                }
            }
            //if (specialNumber >= controlNumber)
            //{
            //    Console.WriteLine("Yes! Control number was reached. Current special number is {0}", specialNumber);
            //}
            //else
            //{
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            //}

            //else
            //{
            //  Console.WriteLine("No! {} is the last reached special number.", specialNumber
            //}

        }
    }
}
