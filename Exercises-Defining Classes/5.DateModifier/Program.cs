using System;


class Program
{
    static void Main(string[] args)
    {
        DateTime fistInput = DateTime.Parse(Console.ReadLine());
        DateTime secondInput = DateTime.Parse(Console.ReadLine());


        DateModifier date = new DateModifier(fistInput, secondInput);

      double result = date.DaysDifference();

        Console.WriteLine(Math.Abs(date.DaysDifference()));
    }
}

