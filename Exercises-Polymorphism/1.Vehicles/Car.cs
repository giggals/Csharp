using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    private const double airCondition = 0.9;

    public Car(double fuelQuantity , double letersPerkm, double tankCapacity) : base(fuelQuantity , letersPerkm , tankCapacity)
    {

    }
    
    public override string DrivenGivenDistance(double distanceToMove)
    {
        var litersToRemove = distanceToMove * (this.LetersPerKm + airCondition);

        if (this.FuelQuantity >= litersToRemove)
        {
            this.FuelQuantity -= litersToRemove;

            return $"{nameof(Car)} travelled {distanceToMove} km";
        }

        return $"{nameof(Car)} needs refueling";
      
    }

    public override void RefueledAmountFuel(double letersTorefuel)
    {
        if (letersTorefuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        var result = this.FuelQuantity  +(letersTorefuel);
        if (result > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {letersTorefuel} fuel in the tank");
        }
        else
        {
            this.FuelQuantity = this.FuelQuantity + (letersTorefuel);
        }
    }
}

