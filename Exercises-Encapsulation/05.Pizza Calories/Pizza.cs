using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private string name;
    private List<Topping> listToppings;
    private Dough dough;

    public Pizza()
    {
        this.listToppings = new List<Topping>();
    }


    public Pizza(string name)
        : this()
    {
        this.Name = name;

    }

    private double ToppingsCalories

    {
        get
        {
            if (this.listToppings.Count == 0)
            {
                return 0;
            }
            return this.listToppings.Select(t => t.ToppingCalories).Sum();
        }
    }

    private double Calories => this.DoughName.Calories + this.ToppingsCalories;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            name = value;
        }
    }


    public List<Topping> Toppings
    {
        get { return listToppings; }
        set { listToppings = value; }
    }

    public Dough DoughName
    {
        get { return dough; }
        set { dough = value; }
    }

    public void SetDough(Dough dough)
    {
        if (this.DoughName == null)
        {
            this.DoughName = dough;
        }
    }

    public void AddTopping(Topping topping)
    {
        listToppings.Add(topping);
        if (listToppings.Count < 0 || listToppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories:f2} Calories.";
    }
}

