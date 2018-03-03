using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle : Shape
{
    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set
        {
            Validation(value);
            width = value;
        }
    }
    
    public double Height
    {
        get { return height; }
        set
        {
            Validation(value);
            height = value;
        }
    }

    public override double CalculatePerimeter()
    {
        double result = 2 * this.Width + 2 * this.Height;
        return result;
    }

    public override double CalculateArea()
    {
        double result = this.Width * this.height;
        return result;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }

    public void Validation(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(this.Validation), "Must be positive");
        }
    }
}

