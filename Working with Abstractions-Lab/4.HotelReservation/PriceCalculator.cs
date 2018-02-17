using System;
using System.Collections.Generic;
using System.Text;


public class PriceCalculator
{
    private decimal pricePerDay;
    private int numberOfDays;
    private Discount_type typeOfdiscount;
    private SeasonPrice seasonPrice;

    public decimal PriceperDay
    {
        get { return this.pricePerDay; }
        set { this.pricePerDay = value; }
    }

    public int NumberOfDays
    {
        get { return this.numberOfDays; }
        set { this.numberOfDays = value; }
    }

    public PriceCalculator(string command)
    {
        var commandArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

       pricePerDay = decimal.Parse(commandArgs[0]);
        numberOfDays = int.Parse(commandArgs[1]);
        seasonPrice = Enum.Parse<SeasonPrice>(commandArgs[2]);
        typeOfdiscount = Discount_type.noDiscount;
        if (commandArgs.Length > 3)
        {
            typeOfdiscount = Enum.Parse<Discount_type>(commandArgs[3]);
        }
    }

    public string Price()
    {
        decimal discount = (int)typeOfdiscount;
       decimal temp = pricePerDay * numberOfDays * (int)seasonPrice;
        decimal discoutPercentage = discount  * (decimal)0.01;
        decimal totalPrice = temp - (temp * discoutPercentage);
        return $"{totalPrice:f2}";

    }

}

