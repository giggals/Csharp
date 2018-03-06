using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle
{
    public Vehicle(double fuelQuantity , double letersPerKm ,double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.LetersPerKm = letersPerKm;
        this.TankCapacity = tankCapacity;
    }

    private double fuelQuantity;
    private double letersPerKm;
    private double tankCapacity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
    
    public double LetersPerKm
    {
        get { return letersPerKm; }
        set { letersPerKm = value; }
    }


    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }

   

    public abstract string DrivenGivenDistance(double distance);

    public abstract void RefueledAmountFuel(double letersToAdd);
}

