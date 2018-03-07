using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int classes = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneyPerLecture = budget / classes;

            double salaryJelev = 0;
            double salaryRoyal = 0;
            double salaryRoli = 0;
            double salaryTrofon = 0;
            double salarySino = 0;
            double salaryOthers = 0;

            for (int i = 0; i < classes; i++)
            {
                string trainer = Console.ReadLine();
                if (trainer == "Jelev")
                {
                    salaryJelev += 1;
                }
                else if (trainer == "RoYaL")
                {
                    salaryRoyal += 1;
                }
                else if (trainer == "Roli")
                {
                    salaryRoli += 1;     
                }
                else if (trainer == "Trofon")
                {
                    salaryTrofon += 1;
                }
                else if (trainer == "Sino")
                {
                    salarySino += 1;
                }
                else
                {
                    salaryOthers += 1;
                }
            }

            Console.WriteLine($"Jelev salary: {salaryJelev *= moneyPerLecture:f2} lv");
            Console.WriteLine($"RoYaL salary: {salaryRoyal *= moneyPerLecture:f2} lv");
            Console.WriteLine($"Roli salary: {salaryRoli *= moneyPerLecture:f2} lv");
            Console.WriteLine($"Trofon salary: {salaryTrofon *= moneyPerLecture:f2} lv");

            Console.WriteLine($"Sino salary: {salarySino *= moneyPerLecture:f2} lv");
            Console.WriteLine($"Others salary: {salaryOthers *= moneyPerLecture:f2} lv");

        }
    }
}
