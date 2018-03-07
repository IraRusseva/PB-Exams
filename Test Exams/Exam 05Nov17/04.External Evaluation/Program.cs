using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int pupils = int.Parse(Console.ReadLine());

            double poorsPupils = 0;
            double satisfactoryPupils = 0;
            double goodPupils = 0;
            double veryGoodPupils = 0;
            double excellentPupils = 0;

            double poorMarks = 0;
            double satisfactoryMarks = 0;
            double goodMarks = 0;
            double veryGoodMarks = 0;
            double excellentMarks = 0;

            for (int i = 0; i < pupils; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points <= 22.5)
                {
                    poorsPupils += 1;
                   // poorMarks += points;
                }
                else if (points > 22.5 && points <= 40.5)
                {
                    satisfactoryPupils += 1;
                    //satisfactoryMarks += points;
                }
                else if (points > 40.5 && points <= 58.5)
                {
                    goodPupils += 1;
                    //goodMarks += points;
                }
                else if(points > 58.5 && points <= 76.5)
                {
                    veryGoodPupils += 1;
                    //veryGoodMarks += points;
                }
                else if(points > 76.5)
                {
                    excellentPupils += 1;
                    //excellentMarks += points;
                }
                poorMarks = (poorsPupils / pupils) * 100;
                satisfactoryMarks = (satisfactoryPupils / pupils) * 100;
                goodMarks = (goodPupils / pupils) * 100;
                veryGoodMarks = (veryGoodPupils / pupils) * 100;
                excellentMarks = (excellentPupils / pupils) * 100;

            }
            Console.WriteLine($"{poorMarks:f2}% poor marks");
            Console.WriteLine($"{satisfactoryMarks:f2}% satisfactory marks");
            Console.WriteLine($"{goodMarks:f2}% good marks");
            Console.WriteLine($"{veryGoodMarks:f2}% very good marks");
            Console.WriteLine($"{excellentMarks:f2}% excellent marks");


        }
    }
}
