using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier
{
    private DateTime firstDate = new DateTime();
    private DateTime secondDate = new DateTime();

    public DateTime FirstDate
    {
        get { return this.firstDate; }
        set { this.firstDate = value; }
    }

    public DateTime SecondDate
    {
        get { return this.secondDate; }
        set { this.secondDate = value; }
    }

    public DateModifier()
    {
        this.FirstDate = firstDate;
        this.SecondDate = secondDate;
    }

    public DateModifier(DateTime first, DateTime second)
    {
        this.FirstDate = first;
        this.SecondDate = second;
    }

    public double DaysDifference()
    {
        return (FirstDate - SecondDate).TotalDays;
    }

}
