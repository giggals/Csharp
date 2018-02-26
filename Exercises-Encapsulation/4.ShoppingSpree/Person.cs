using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products = new List<Product>();
    
   
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
         set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }

    public List<Product> Products
    {
        get { return this.products; }
        set { this.products = value; }
       
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
    }

    public string BuyProduct(Product product)
    {

        if (product.Cost > this.Money)
        {
           return ($"{this.Name} can't afford {product.ProductName}");
        }

        this.Money -= product.Cost;
       this.products.Add(product);

        return ($"{this.Name} bought {product.ProductName}");

    }

}

