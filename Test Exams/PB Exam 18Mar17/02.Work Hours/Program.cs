using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int countOfDays = int.Parse(Console.ReadLine());

            double workingHours = countOfDays * countOfWorkers * 8;

            if (workingHours >= hoursNeeded)
            {
                double hoursLeft = workingHours - hoursNeeded;
                Console.WriteLine($"{hoursLeft} hours left");
            }
            else
            {
                double hoursNotEnough = hoursNeeded - workingHours;
                double penalties = hoursNotEnough * countOfDays;
                Console.WriteLine($"{hoursNotEnough} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
