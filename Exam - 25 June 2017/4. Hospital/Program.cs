using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, List<string>> departaments = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "Output")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string department = commandArgs[0];
                string doctorname = commandArgs[1] + " " + commandArgs[2];
                string patientName = commandArgs[3];


                if (!departaments.ContainsKey(department))
                {
                    departaments.Add(department, new List<string>());
                }

                departaments[department].Add(patientName);

                if (!doctors.ContainsKey(doctorname))
                {
                    doctors.Add(doctorname, new List<string>());
                }

                doctors[doctorname].Add(patientName);
                
            }
            
            string printCommand;

            while ((printCommand = Console.ReadLine()) != "End")
            {
                string[] printComArgs = printCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
               

                if (printComArgs.Length == 1)
                {
                    string department = printComArgs[0];
                    foreach (var item in departaments[department])
                    {
                        Console.WriteLine(item);
                    }
                }

                int roomNumber;
                if (printComArgs.Length == 2 && int.TryParse(printComArgs[1], out roomNumber))
                {
                    string department = printComArgs[0];
                    roomNumber = int.Parse(printComArgs[1]);

                    var formula = (roomNumber - 1) * 3;

                    foreach (var item in departaments[department].Skip(formula).Take(3).OrderBy(p => p))
                    {
                        Console.WriteLine(item);
                    }
                    
                }
                if (printComArgs.Length == 2 && (!int.TryParse(printComArgs[1], out roomNumber)))
                {
                    string doctorName = printComArgs[0] + " " + printComArgs[1];

                    foreach (var item in doctors[doctorName].OrderBy(p => p))
                    {
                        Console.WriteLine(item);
                    }
                }
                
            }
            
        }
    }
}
