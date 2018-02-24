using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Drive drive = new Drive();

        for (int i = 0; i < n; i++)
        {
            string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = commandArgs[0];
            double fuelAmount = double.Parse(commandArgs[1]);
            double fuelConsumation = double.Parse(commandArgs[2]);

            Car car = new Car(model, fuelAmount, fuelConsumation);
            drive.AddToList(car);

        }

        List<double> list = new List<double>();
        string command = "";
     
        drive.DriveCar(command);
      
    }
}