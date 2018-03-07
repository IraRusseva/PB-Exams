using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricityTotal = 0.0;
            double water = 0;
            double internet= 0;
            double otherBills = 0;
            double average = 0;
            for (int i = 0; i < months; i++)
            {
                double readnumber = double.Parse(Console.ReadLine());

                electricityTotal += readnumber;
                water = 20 * months;
                internet = 15 * months;
                otherBills = (electricityTotal + water + internet) * 1.20;
                average = (electricityTotal + water + internet + otherBills) / months;

            }
            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {otherBills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");


        }
    }
}
