using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine().ToLower();
            string type = Console.ReadLine().ToLower();
            string net = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());

            double price = 0.0;
            double internet = 0.0;

            if (years == "one" && type == "small")
            {
                price = 9.98;
                if (net == "yes")
                {
                    internet = 5.50;
                }
            }
            else if (years == "one"  && type == "middle")
            {
                price = 18.99;
                if (net == "yes")
                {
                    internet = 4.35;
                }
            }
            else if (years == "one" && type == "large")
            {
                price = 25.98;
                if (net == "yes")
                {
                    internet = 4.35;
                }
            }
            else if (years == "one" && type == "extralarge")
            {
                price = 35.99;
                if (net == "yes")
                {
                    internet = 3.85;
                }
            }
            if (years == "two" && type == "small")
            {
                price = 8.58;
                if (net == "yes")
                {
                    internet = 5.50;
                }
            }
            else if (years == "two" && type == "middle")
            {
                price = 17.09;
                if (net == "yes")
                {
                    internet = 4.35;
                }
            }
            else if (years == "two" && type == "large")
            {
                price = 23.59;
                if (net == "yes")
                {
                    internet = 4.35;
                }
            }
            else if (years == "two" && type == "extralarge")
            {
                price = 31.79;
                if (net == "yes")
                {
                    internet = 3.85;
                }
            }
            double totalSum = (price + internet) * months;
            if (years == "two")
            {
                double discount = (totalSum * 3.75) / 100;
                totalSum -= discount;
            }
            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
