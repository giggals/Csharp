using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var engines = new List<Engine>();
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = command[0];
            int power = int.Parse(command[1]);
            string displacemenet = "n/a";
            string efficiency = "n/a";
            if (command.Length >= 3)
            {
                if (!int.TryParse(command[2], out _))
                {
                    efficiency = command[2];
                }
                else
                {
                    displacemenet = command[2];

                }

            }
            if (command.Length >= 4)
            {
                if (int.TryParse(command[2], out _))
                {
                    displacemenet = command[2];
                    efficiency = command[3];
                }

            }
            Engine engin = new Engine(model, power, displacemenet, efficiency);
            engines.Add(engin);
        }
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string carModel = input[0];
            string engineModel = input[1];
            string weight = "n/a";
            string colour = "n/a";
            if (input.Length >= 3)
            {
                if (!int.TryParse(input[2], out _))
                {
                    colour = input[2];
                }
                else
                {
                    weight = input[2];
                }

            }
            if (input.Length >= 4)
            {
                if (int.TryParse(input[2], out _))
                {
                    weight = input[2];
                    colour = input[3];
                }

            }
            var car = new Car(carModel, engineModel, weight, colour);
            cars.Add(car);


        }
        
        foreach (var item in cars)
        {
            Console.WriteLine($"{item.Model}:");
            Console.WriteLine($"  {item.EngineReference}:");
            Console.WriteLine($"    Power: {engines.Where(x => x.Model == item.EngineReference).Select(p => p.Power).First()}");
            Console.WriteLine($"    Displacement: {engines.Where(x => x.Model == item.EngineReference).Select(d => d.Displacmenet).First()}");
            Console.WriteLine($"    Efficiency: {engines.Where(x => x.Model == item.EngineReference).Select(e=> e.Efficiency).First()}");
            Console.WriteLine($"  Weight: {item.Weight}");
            Console.WriteLine($"  Color: {item.Color}");
        }
        
    }
}

