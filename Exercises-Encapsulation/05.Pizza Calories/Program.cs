using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            string[] pizzaInput = Console.ReadLine().Split(" ");
            string pizzaName = pizzaInput[1];
            Pizza pizza = new Pizza(pizzaName);

            string[] doughInput = Console.ReadLine().Split(" ");
            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doubleWeight = double.Parse(doughInput[3]);


            Dough dough = new Dough(flourType.ToLower(), bakingTechnique, doubleWeight);
            pizza.SetDough(dough);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(" ");
                string toppingName = input[1];
                double weight = double.Parse(input[2]);

                Topping topping = new Topping(toppingName, weight);
                pizza.AddTopping(topping);
            }
           
            Console.WriteLine(pizza);
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

   

   
}

