using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        PriceCalculator price = new PriceCalculator(input);
        var totalPrice = price.Price();
        Console.WriteLine(totalPrice);

    }
}

