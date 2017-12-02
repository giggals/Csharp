using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] grades = Console.ReadLine().Split();
                var name = grades[0];
                var grade = double.Parse(grades[1]);

                if (!(dict.ContainsKey(name)))
                {
                    dict[name] = new List<double>() { grade };
                }
               else
                    dict[name].Add(grade);
                
            }
            foreach (var item in dict)
            {
                var name = item.Key;
                var studentsGrade = item.Value;
                var average = studentsGrade.Average();
                Console.Write($"{name} -> " );
                foreach (var value in studentsGrade)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
            
        }
    }
}
