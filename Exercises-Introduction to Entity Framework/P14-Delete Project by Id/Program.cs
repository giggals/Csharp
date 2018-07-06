using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P14_Delete_Project_by_Id
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var projets = context.Projects.
                    Take(10)
                    .Select(p => new
                    {
                        p.Name,
                    })
                    .ToArray();

                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P14-Delete Project by Id\P14";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var p in projets)
                    {
                        sw.WriteLine(p.Name);
                    }
                }
                
            }
        }
    }
}
