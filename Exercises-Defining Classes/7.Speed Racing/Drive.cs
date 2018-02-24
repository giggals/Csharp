using System;
using System.Collections.Generic;
using System.Text;


public class Drive
{
    private string carModel;
    private double amountOfKm;
    private double fuelAmount;
    private List<Car> cars;

    public List<Car> CarsList
    {
        get { return this.cars; }
        set { this.cars = value; }
    }


    public void AddToList(Car model)
    {
        CarsList.Add(model);
    }


    public double AmountOfKm
    {
        get { return this.amountOfKm; }
        set { this.amountOfKm = value; }
     
    }

    public string CarModel
    {
        get { return this.carModel; }
        set { this.carModel = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public Drive()
    {
        this.cars = new List<Car>();
    }


    public Drive(string carModel,double amountOfKm)
    {
        this.CarModel = carModel;
        this.AmountOfKm = amountOfKm;
   
    }

    public void DriveCar(string command)
    {
        Dictionary<string, double> dict = new Dictionary<string, double>();
      
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commmandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            carModel = commmandArgs[1];
            amountOfKm = double.Parse(commmandArgs[2]);
           
            foreach (var item in CarsList)
            {
                if (item.Model == carModel)
                {
                    if (item.FuelPerKilometer * amountOfKm <= item.FuelAmount)
                    {
                        item.FuelAmount = item.FuelAmount;
                        item.FuelAmount -= amountOfKm * item.FuelPerKilometer;
                        item.AmountOfKM = amountOfKm;
                        if (!dict.ContainsKey(item.Model))
                        {
                            dict.Add(item.Model, amountOfKm);
                        }
                        else
                        {
                            item.AmountOfKM = dict[item.Model] += amountOfKm;

                        }
                      
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }

                }

            }
            
        }
        foreach (var item in CarsList)
        {
            Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.AmountOfKM}");
        }
    
    }


}

