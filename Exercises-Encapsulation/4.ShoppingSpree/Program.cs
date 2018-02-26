using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Person> people;
            List<Product> products;

            PeopleInput(out people, out products);

            ProductsInput(products);

            BuyCommands(people, products);
            PintNamesAndProducts(people);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static void PintNamesAndProducts(List<Person> people)
    {
        foreach (var item in people)
        {
            if (item.Products.Count == 0)
            {
                Console.WriteLine($"{item.Name} - Nothing bought");
                continue;
            }

            Console.Write($"{item.Name} -");
            for (int i = 0; i < item.Products.Count; i++)
            {
                Console.Write($" {item.Products[i].ProductName}");
                if (i == item.Products.Count - 1)
                {
                    continue;
                }
                else
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PeopleInput(out List<Person> people, out List<Product> products)
    {
        string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        people = new List<Person>();
        products = new List<Product>();
        foreach (var item in input)
        {
           
            string[] parsedItem = item.Split("=");
            string personName = parsedItem[0];
            decimal money = decimal.Parse(parsedItem[1]);

            Person person = new Person(personName, money);
            people.Add(person);
        }
    }

    private static void ProductsInput(List<Product> products)
    {
        string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in productsInput)
        {
            string[] parsedProduct = item.Split("=");
            string productName = parsedProduct[0];
            decimal cost = decimal.Parse(parsedProduct[1]);

            Product productInClass = new Product(productName, cost);
            products.Add(productInClass);
        }
    }

    private static void BuyCommands(List<Person> people, List<Product> products)
    {
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] buyProduct = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string person = buyProduct[0];
            string product = buyProduct[1];

            var prod = products.Where(c => c.ProductName == product).First();

            foreach (var item in people.Where(x => x.Name == person))
            {
                Console.WriteLine(item.BuyProduct(prod));
            }

        }

    }
}

