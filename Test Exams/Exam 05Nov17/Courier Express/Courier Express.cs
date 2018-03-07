using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            double km = double.Parse(Console.ReadLine());

            double price = 0.0;
            if (type == "standart")
            {
                price = 0.03 * km;
                if (kg > 1 && kg <= 10)
                {
                    price = 0.05 * km;
                }
                else if (kg > 10 && kg <=40)
                {
                    price = 0.10 * km;
                }
                else if (kg > 40 && kg <= 90)
                {
                    price = 0.15 * km;
                }
                else if (kg > 10 && kg <= 150)
                {
                    price = 0.20 * km;
                }
            }
            else if (type == "express")
            {
                if (kg <= 1)
                {
                    price = (((0.03 * 0.8) * kg) * km) + (0.03 * kg);
                }
                else if (kg > 1 && kg <= 10)
                {
                    price = (((0.05 * 0.4) * kg) * km) + (0.05 * kg);
                }
                else if (kg > 10 && kg <= 40)
                {
                    price = (((0.10 * 0.05) * kg) * km) + (0.10 * kg);
                }
                else if (kg > 40 && kg <= 90)
                {
                    price = (((0.15 * 0.02) * kg) * km) + (0.15 * kg);
                }
                else if (kg > 90 && kg <= 150)
                {
                    price = (((0.20 * 0.01) * kg) * km) + (0.20 * kg);
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {price:f2} lv.");
        }
    }
}
