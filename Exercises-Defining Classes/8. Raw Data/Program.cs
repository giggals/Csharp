using System;
using System.Linq;

 public class Program
{
    static void Main(string[] args)
    {
        int carsAmount = int.Parse(Console.ReadLine());
        Car[] cars = new Car[carsAmount];
       
        for (int carNumber = 0; carNumber < carsAmount; carNumber++)
        {
            string[] inputArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string carModel = inputArgs[0];
            int egineSpeed = int.Parse(inputArgs[1]);
            int powerEngine = int.Parse(inputArgs[2]);
            int cargoWeight = int.Parse(inputArgs[3]);
            string cargoType = inputArgs[4];
            double firstTirePres = double.Parse(inputArgs[5]);
            int firstTireyear = int.Parse(inputArgs[6]);
            double secondTirePres = double.Parse(inputArgs[7]);
            int secondTireyear = int.Parse(inputArgs[8]);
            double thirdTirePres = double.Parse(inputArgs[9]);
            int thirdTireyear = int.Parse(inputArgs[10]);
            double fourthtirePres = double.Parse(inputArgs[11]);
            int fourthTireyear = int.Parse(inputArgs[12]);

             cars[carNumber]    = new Car(inputArgs[0],new Engine(int.Parse(inputArgs[1]),int.Parse(inputArgs[2])),new Cargo(int.Parse(inputArgs[3]), inputArgs[4]),new Tire( double.Parse(inputArgs[5]), int.Parse(inputArgs[6]), double.Parse(inputArgs[7]), int.Parse(inputArgs[8]),double.Parse (inputArgs[9]), int.Parse(inputArgs[10]), double.Parse(inputArgs[11]), int.Parse(inputArgs[12])));
            
        }
        string command = Console.ReadLine();
        switch (command)
        {
            case "fragile":
                 cars.Where(x => x.Cargo.CargoType == "fragile").Where(t => t.Tire.Tire1Pressure < 1 || t.Tire.Tire2Pressure < 1 || t.Tire.Tire3Pressure < 1 || t.Tire.Tire4Pressure < 1).Select(n => n.Model).ToList().ForEach(i => Console.WriteLine(i));
                
            break;
            case "flamable":
                cars.Where(x => x.Cargo.CargoType == "flamable").Where(e => e.Engine.EnginePower > 250).Select(s => s.Model).ToList().ForEach(i => Console.WriteLine(i));
               
                break;
        }
    }
}

