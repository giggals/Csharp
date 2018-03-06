using System;


public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Vehicle car = CarInput();
            Vehicle truck = TruckInput();
            Bus bus = BusInput();

            int CommandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < CommandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(" ");
                string action = commandArgs[0];
                string vehicle = commandArgs[1];
                SwitchCommand(car, truck, bus, commandArgs, action, vehicle);

            }
            PrintFuelLeft(car, truck,bus);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    private static Bus BusInput()
    {
        string[] busInput = Console.ReadLine().Split(" ");
        double fuelAmount = double.Parse(busInput[1]);
        double litersPerKm = double.Parse(busInput[2]);
        double tankCapacity = double.Parse(busInput[3]);
        Bus bus = new Bus(fuelAmount, litersPerKm, tankCapacity);
        ChekFuel(fuelAmount, tankCapacity);
        return bus;
    }

    private static Vehicle TruckInput()
    {
        string[] truckInput = Console.ReadLine().Split();
        double truckFuelQuantity = double.Parse(truckInput[1]);
        double truckLetersPerKm = double.Parse(truckInput[2]);
        double truckTankCapacity = double.Parse(truckInput[3]);
        Vehicle truck = new Truck(truckFuelQuantity, truckLetersPerKm, truckTankCapacity);
        ChekFuel(truckFuelQuantity, truckTankCapacity);
        return truck;
    }

    private static Vehicle CarInput()
    {
        string[] carInput = Console.ReadLine().Split(" ");
        double carFuelQuantity = double.Parse(carInput[1]);
        double carLetersPerKm = double.Parse(carInput[2]);
        double tankCapacity = double.Parse(carInput[3]);
        Vehicle car = new Car(carFuelQuantity, carLetersPerKm, tankCapacity);
        ChekFuel(carFuelQuantity, tankCapacity);
        return car;
    }

    private static void SwitchCommand(Vehicle car, Vehicle truck,Bus bus, string[] commandArgs, string action, string vehicle)
    {

        try
        {
            switch (action)
            {
                case "Drive":
                    double distance = double.Parse(commandArgs[2]);
                    if (vehicle == "Car")
                    {
                        Console.WriteLine(car.DrivenGivenDistance(distance));
                    }
                    else if (vehicle == "Bus")
                    {
                        Console.WriteLine(bus.DrivenGivenDistance(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.DrivenGivenDistance(distance));
                    }
                    break;
                case "Refuel":
                    double liters = double.Parse(commandArgs[2]);
                    if (vehicle == "Truck")
                    {
                        truck.RefueledAmountFuel(liters);
                    }
                    else if (vehicle == "Bus")
                    {
                        bus.RefueledAmountFuel(liters);
                    }
                    
                    else
                    {
                        car.RefueledAmountFuel(liters);
                    }
                    break;
                case "DriveEmpty":
                    double distanceEmpty = double.Parse(commandArgs[2]);
                    Console.WriteLine(bus.DrivenGivenDistanceEmpty(distanceEmpty));
                    break;

            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static void PrintFuelLeft(Vehicle car, Vehicle truck,Bus bus)
    {
        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
    }

    public static void ChekFuel(double fuelAmount , double tankCapacity)
    {
        if (fuelAmount > tankCapacity)
        {
            tankCapacity = 0;
        }
    }
}

