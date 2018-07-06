using P02_DatabaseFirst.Data;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace P11_Find_Latest_10_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var projets = context
                    .Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .Select(d => new
                    {
                        d.Name,
                        d.Description,
                        d.StartDate,
                    })
                    .OrderBy(d => d.Name)
                    .ToArray();


                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P11_Find Latest 10 Projects\P11";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var p in projets)
                    {
                        sw.WriteLine(p.Name);
                        sw.WriteLine(p.Description);
                        sw.WriteLine(p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
                    }
                }

            }
        }
    }
}
