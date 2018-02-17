using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private Point topleft;
    private Point bottormRight;

    public Point TopLeft
    {
        get { return this.topleft; }
        set { this.topleft = value; }
    }

    public Point BottomRight
    {
        get { return this.bottormRight; }
        set { this.bottormRight = value; }
    }
    
    public Rectangle(int topX,int topY,int bottomX,int bottomY)
    {
        this.TopLeft = new Point(topX,topY);
        this.BottomRight = new Point(bottomX,bottomY);
        
    }

    public bool Contains(Point point)
    {
        var contains = TopLeft.X <= point.X && BottomRight.X >= point.X && 
                       TopLeft.Y <= point.Y && BottomRight.Y >= point.Y;
        
            return contains;
      
    }

}

