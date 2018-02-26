using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    private string productName;
    private decimal cost;


    public string ProductName
    {
        get { return productName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            productName = value;
        }
    }


    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            cost = value;
        }
    }

    public Product(string productName, decimal cost)
    {
        this.ProductName = productName;
        this.Cost = cost;
    }


}

