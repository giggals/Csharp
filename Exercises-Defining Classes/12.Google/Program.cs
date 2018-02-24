using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var peoples = new Dictionary<string, List<Person>>();


        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personName = commandArgs[0];

            InputParse(commandArgs, peoples);
        }

        string getInfoFor = Console.ReadLine();

        PrintMethod(peoples, getInfoFor);

    }

    private static void PrintMethod(Dictionary<string, List<Person>> peoples, string getInfoFor)
    {
        if (peoples.ContainsKey(getInfoFor))
        {
            Console.WriteLine($"{getInfoFor}");
            foreach (var item in peoples.Values)
            {
                Console.WriteLine($"Company:");
                Console.WriteLine($"{item.Where(x => x.Name == getInfoFor).Select(y => y.Comp).Select(u => u.CompanyName).First()}");
                break;
            }
        }
    }

    private static void InputParse(string[] commandArgs, Dictionary<string, List<Person>> peoples)
    {
        string personName = commandArgs[0];
        switch (commandArgs[1])
        {
            case "company":
                string companyName = commandArgs[2];
                string departMent = commandArgs[3];
                decimal salary = decimal.Parse(commandArgs[4]);

                Company company = new Company(companyName, departMent, salary);
                Person personComp = new Person(personName ,company);

                if (!peoples.ContainsKey(personName))
                {
                    peoples[personName] = new List<Person>();
                }
                peoples[personName].Add(new Person(personName ,company));
                break;

            case "pokemon":
                string pokemonName = commandArgs[2];
                string pokemonType = commandArgs[3];
                Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                Person personPokemon = new Person(personName, pokemon);
                if (!peoples.ContainsKey(personName))
                {
                    peoples[personName] = new List<Person>();
                }
                peoples[personName].Add(new Person(personName,pokemon));
                
                break;
            case "parents":
                string parentName = commandArgs[2];
                DateTime parentBirthday = DateTime.Parse(commandArgs[3]);
                Parents parents = new Parents(parentName, parentBirthday);
                Person personParents = new Person(personName,parents);
                if (!peoples.ContainsKey(personName))
                {
                    peoples[personName] = new List<Person>();
                }
                peoples[personName].Add(new Person(personName,parents));
                break;
            case "children":
                string childName = commandArgs[2];
                DateTime childBirthday =DateTime.Parse(commandArgs[3]);
                Children children = new Children(childName, childBirthday);
                Person personChild = new Person(personName, children);
                if (!peoples.ContainsKey(personName))
                {
                    peoples[personName] = new List<Person>();
                }
                peoples[personName].Add(new Person(personName, children));
                
                break;
            case "car":
             
                string carModel = commandArgs[2];
                int carSpeed = int.Parse(commandArgs[3]);
                Car car = new Car(carModel , carSpeed);
                Person carPerson = new Person(personName, car);
                if (!peoples.ContainsKey(personName))
                {
                    peoples[personName] = new List<Person>();
                }
                peoples[personName].Add(new Person(personName, car));
                break;
        }
    }
}

