using System;
using System.Collections.Generic;
using System.Text;


public class Box
{

    private double lenght;

    public double Lenght
    {
        get { return lenght; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative.");
            }
            lenght = value;
        }
    }
    private double width;

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            width = value;
        }
    }
    private double height;

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            height = value;
        }
    }

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double LateralSurfaceArea(double lenght, double width, double height)
    {
        var lateralSurfaceArea = 2 * lenght * height + 2 * width * height;
        return lateralSurfaceArea;
    }

    public double Volume(double lenght, double width, double height)
    {
        var volume = lenght * width * height;
        return volume;
    }

    public double SurfaceArea(double lenght, double width, double height)
    {
        var surfacearea = 2 * lenght * width + 2 * lenght * height + 2 * width * height;
        return surfacearea;
    }


    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Surface Area - {SurfaceArea(lenght, width, height):f2}");
        stringBuilder.AppendLine($"Lateral Surface Area - {LateralSurfaceArea(lenght, width, height):f2}");
        stringBuilder.AppendLine($"Volume - {Volume(lenght, width, height):f2}");

        return stringBuilder.ToString();

    }

}

