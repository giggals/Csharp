using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Output")
            {
                string[] jetoni = command.Split();
                var departament = jetoni[0];
                var firstName = jetoni[1];
                var secondName = jetoni[2];
                var pacient = jetoni[3];
                var fullName = firstName + secondName;

                if (!doctors.ContainsKey(firstName + secondName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool IsFull = departments[departament].SelectMany(x => x).Count() < 60;
                if (IsFull)
                {
                    int room = 0;
                    doctors[fullName].Add(pacient);
                    for (int roomCount = 0; roomCount < departments[departament].Count; roomCount++)
                    {
                        if (departments[departament][roomCount].Count < 3)
                        {
                            room = roomCount;
                            break;
                        }
                    }
                    departments[departament][room].Add(pacient);
                }

               
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                command = CommandParser(doctors, departments, command);
            }
        }

        private static string CommandParser(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string command)
        {
            string[] args = command.Split();

            if (args.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int staq))
            {
                Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
            }
            command = Console.ReadLine();
            return command;
        }
    }
}
