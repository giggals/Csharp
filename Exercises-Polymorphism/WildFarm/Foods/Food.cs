using System;
using System.Collections.Generic;
using System.Text;


public abstract class Food
{

    public Food(int quantity)
    {
    
        this.Quantity = quantity;
    }
    
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

}

