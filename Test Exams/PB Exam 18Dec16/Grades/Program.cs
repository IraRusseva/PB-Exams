using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfStudents = int.Parse(Console.ReadLine());
            double topStudents = 0;
            double goodStudents = 0;
            double mediumStudents = 0;
            double failStudents = 0;
            double allgrades = 0;
            double average = 0;

            for (int i = 0; i < countOfStudents ; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                allgrades+= grade;
                if (grade >= 5)
                {
                    topStudents++;
                }
                else if (grade < 5 && grade >=4)
                {
                    goodStudents++;
                }
                else if (grade < 4 && grade >=3)
                {
                    mediumStudents++;
                }
                else if (grade < 3)
                {
                    failStudents++;
                }
                
            }
            double percentTopStudents = (topStudents / countOfStudents) * 100;
            double percentStudentsAver4 = (goodStudents / countOfStudents) * 100;
            double percentStudentsOver3 = (mediumStudents / countOfStudents) * 100;
            double percentFailedStudents = (failStudents / countOfStudents) * 100;

            average = allgrades / countOfStudents;

            Console.WriteLine($"Top students: {percentTopStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentStudentsAver4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentStudentsOver3:f2}%");
            Console.WriteLine($"Fail: {percentFailedStudents:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
