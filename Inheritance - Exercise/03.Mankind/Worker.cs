using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private decimal weekSalary;
    private double hoursPerday;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }


    public double HoursPerDay
    {
        get { return hoursPerday; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            hoursPerday = value;
        }
    }

    public Worker(string firstName, string secondName, decimal weekSalary, double hoursPerday)
        : base(firstName, secondName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerday;
    }

   

    public override string ToString()
    {
        Console.WriteLine();
        StringBuilder resultStr = new StringBuilder(base.ToString());
        resultStr.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        resultStr.AppendLine($"Hours per day: {this.HoursPerDay:f2}");
        resultStr.AppendLine($"Salary per hour: {(this.WeekSalary / (decimal)(this.HoursPerDay * 5)):f2}");

        var result = resultStr.ToString().TrimEnd();
        return result;
    }

}

