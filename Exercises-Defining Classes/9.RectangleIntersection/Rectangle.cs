using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private int width;
    private int height;
    private int topLeftHorizontal;
    private int topLeftVertical;

    public string ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public int TopLeftHorizontal
    {
        get { return this.topLeftHorizontal; }
        set { this.topLeftHorizontal = value; }
    }

    public int TopLeftVertical
    {
        get { return this.topLeftVertical; }
        set { this.topLeftVertical = value; }
    }

    public Rectangle(string id, int width, int height, int topLeftHorizontal, int topLeftVertical)
    {
        this.ID = id;
        this.Width = width;
        this.Height = height;
        this.TopLeftHorizontal = topLeftHorizontal;
        this.TopLeftVertical = topLeftVertical;
    }


    public bool ChekRectangle(Rectangle rectangle)
    {
        if (rectangle.TopLeftHorizontal + rectangle.Width >= this.TopLeftHorizontal &&
               rectangle.TopLeftHorizontal + TopLeftHorizontal <= this.topLeftHorizontal + this.Width &&
               rectangle.TopLeftVertical >= this.TopLeftVertical - this.Height &&
               rectangle.TopLeftVertical - rectangle.Height <= this.TopLeftVertical)

        {
            return true;
        }
        return false;
       
    }
}
