using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelPerKilometer;
    private double amountOfKm;


    public double AmountOfKM
    {
        get { return this.amountOfKm; }
        set { this.amountOfKm = value; }
    }
        


    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }


    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }


    public double FuelPerKilometer
    {
        get { return fuelPerKilometer; }
        set { fuelPerKilometer = value; }
    }

    public Car(string model)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelPerKilometer = fuelPerKilometer;
    }


    public Car(string model, double fuelAmount, double fuelPerKilometer)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelPerKilometer = fuelPerKilometer;
    }

}

